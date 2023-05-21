using Microsoft.EntityFrameworkCore;
using RosePlus.AppServices.Repositories;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

/// <inheritdoc />
public class CategoryRepository : ICategoryRepository
{
    /// <summary>
    /// Репозиторий для работы с категорями <see cref="CategoryEntity"/>>.
    /// </summary>
    private readonly IRepository<CategoryEntity> _repository;

    public CategoryRepository(IRepository<CategoryEntity> repository)
    {
        _repository = repository;
    }

    /// <inheritdoc />
    public Task<CategoryEntity> GetCategoryById(int categoryId, CancellationToken cancellationToken)
    {
        return _repository.GetEntityById(categoryId, cancellationToken);
    }

    public Task<List<CategoryEntity>> GetAllCategories(CancellationToken cancellationToken)
    {
        return _repository.GetAllEntities().ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public Task<int> AddCategory(CategoryEntity categoryEntity, CancellationToken cancellationToken)
    {
        return _repository.AddEntity(categoryEntity, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteCategory(int categoryId, CancellationToken cancellationToken)
    {
        await _repository.DeleteEntity(categoryId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateCategory(CategoryEntity categoryEntity, CancellationToken cancellationToken)
    {
        await _repository.UpdateEntity(categoryEntity, cancellationToken);
    }
}