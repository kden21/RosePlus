using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Exceptions;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

/// <inheritdoc />
public class Repository<TEntity> : IRepository<TEntity> where TEntity: BaseEntity
{
    protected  DbContext DbContext { get; }
    protected DbSet<TEntity> DbSet { get; }
    
    public Repository(DbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = DbContext.Set<TEntity>();
    }
    
    /// <inheritdoc />
    public IQueryable<TEntity> GetAllEntities()
    {
        return DbSet;
    }

    /// <inheritdoc />
    public async Task<TEntity> GetEntityById(int TEntityId, CancellationToken cancellation)
    {
        var entity = await DbSet.FirstOrDefaultAsync(a=> a.Id == TEntityId, cancellation);
        if(entity == null)
            throw new EntityNotFoundException($"Не существует сущности с идентификатором '{TEntityId}'");
        
        return entity;
    }

    /// <inheritdoc />
    public async Task<int> AddEntity(TEntity model, CancellationToken cancellation)
    {
        if (model == null)
            throw new EntityNotFoundException($"Модель представления не может быть null");
        
        model.CreateDate = DateTime.UtcNow;
        model.ModifyDate = model.CreateDate;
        
        var entityEntry = await DbContext.AddAsync(model, cancellation);
        
        try
        {
            await DbContext.SaveChangesAsync(cancellation);
            return entityEntry.Entity.Id;
        }
        catch(Exception exception)
        {
            throw new EntityCreateException("Не удалось добавить сущность в БД");
        }
    }

    /// <inheritdoc />
    public async Task UpdateEntity(TEntity model, CancellationToken cancellation)
    {
        if (model == null)
            throw new EntityNotFoundException("Модель представления не может быть null");
        try
        {
            model.ModifyDate = DateTime.UtcNow;
            DbSet.Update(model);
            await DbContext.SaveChangesAsync(cancellation);
        }
        catch (Exception exception)
        {
            throw new EntityUpdateException("Не удалось обновить сущность");
        }
    }

    /// <inheritdoc />
    public async Task DeleteEntity(int TEntityId, CancellationToken cancellation)
    {
        var model = await GetEntityById(TEntityId, cancellation);
        if (model == null)
            throw new EntityNotFoundException($"Не удалось удалить сущность с идентификатором '{TEntityId}', т.к. она не была найдена в БД");
        
        DbSet.Remove(model);
        await DbContext.SaveChangesAsync(cancellation);
    }
    
    /// <inheritdoc />
    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
    {
        if (predicate == null)
        {
            throw new ArgumentException(null, nameof(predicate));
        }

        return DbSet.Where(predicate);
    }
}