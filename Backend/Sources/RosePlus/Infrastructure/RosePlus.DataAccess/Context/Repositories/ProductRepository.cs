using Microsoft.EntityFrameworkCore;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Filters;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

/// <inheritdoc />
public class ProductRepository : IProductRepository
{
    /// <summary>
    /// Репозитеорий для работы с товаром <see cref="ProductEntity"/>>.
    /// </summary>
    private readonly IRepository<ProductEntity> _repository;

    public ProductRepository(IRepository<ProductEntity> repository)
    {
        _repository = repository;
    }
    
    /// <inheritdoc />
    public Task<ProductEntity> GetProductById(int productId, CancellationToken cancellationToken)
    {
        return _repository.GetEntityById(productId, cancellationToken);
    }

    /// <inheritdoc />
    public Task<List<ProductEntity>> GetProducts(ProductFilter productFilter, CancellationToken cancellationToken)
    {
        return _repository.Where(x => x.CategoryId == productFilter.CategoryId).ToListAsync(cancellationToken);
    }
    
    /// <inheritdoc />
    public async Task<int> AddProduct(ProductEntity productEntity, CancellationToken cancellationToken)
    {
       return await _repository.AddEntity(productEntity, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteProduct(int productId, CancellationToken cancellationToken)
    {
        await _repository.DeleteEntity(productId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateProduct(ProductEntity productEntity, CancellationToken cancellationToken)
    {
        await _repository.UpdateEntity(productEntity, cancellationToken);
    }
}