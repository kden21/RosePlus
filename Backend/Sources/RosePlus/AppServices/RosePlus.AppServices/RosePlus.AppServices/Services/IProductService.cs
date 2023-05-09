using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Requests;

namespace RosePlus.AppServices.Services;

/// <summary>
/// Сервис работы с товарами.
/// </summary>
public interface IProductService
{
    Task<ProductDto> GetProductByIdAsync(int productId, CancellationToken cancellationToken);
    Task<IEnumerable<ProductDto>> GetProductsAsync(ProductRequest productRequest, CancellationToken cancellationToken);
    Task<int> AddProductAsync(ProductDto productDto, CancellationToken cancellationToken);
}