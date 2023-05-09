using Microsoft.EntityFrameworkCore;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Requests;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IRepository<ProductEntity> _repository;

    public ProductRepository(IRepository<ProductEntity> repository)
    {
        _repository = repository;
    }
    
    public Task<ProductEntity> GetProductById(int productId, CancellationToken cancellationToken)
    {
        return _repository.GetEntityById(productId, cancellationToken);
    }

    public Task<List<ProductEntity>> GetProducts(ProductRequest productRequest, CancellationToken cancellationToken)
    {
        return _repository.Where(x => x.CategoryId == productRequest.CategoryId).ToListAsync(cancellationToken);
    }

    public async Task<int> AddProduct(ProductEntity productEntity, CancellationToken cancellationToken)
    {
       return await _repository.AddEntity(productEntity, cancellationToken);
    }
}