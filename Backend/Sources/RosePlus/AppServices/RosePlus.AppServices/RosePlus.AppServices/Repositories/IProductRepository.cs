using RosePlus.Contracts.Requests;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

public interface IProductRepository
{
    Task<ProductEntity> GetProductById(int productId, CancellationToken cancellationToken);
    Task<List<ProductEntity>> GetProducts(ProductRequest productRequest,CancellationToken cancellationToken);
    Task<int> AddProduct(ProductEntity productEntity, CancellationToken cancellationToken);
}