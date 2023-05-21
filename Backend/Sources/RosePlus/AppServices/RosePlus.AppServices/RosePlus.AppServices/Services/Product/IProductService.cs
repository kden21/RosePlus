using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;

namespace RosePlus.AppServices.Services.Product;

/// <summary>
/// Сервис работы с товарами.
/// </summary>
public interface IProductService
{
    /// <summary>
    /// Метод для получения товара по идентификатору.
    /// </summary>
    /// <param name="productId">Идентиикатор товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Товар.</returns>
    Task<ProductDto> GetProductByIdAsync(int productId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для получения коллекции товаров по фильтру.
    /// </summary>
    /// <param name="productFilter">Параметр фильтрации.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Коллекция товаров.</returns>
    Task<IEnumerable<ProductDto>> GetProductsAsync(ProductFilter productFilter, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод добавления товара.
    /// </summary>
    /// <param name="productDto">Модель представления товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Идентификатор товара.</returns>
    Task<int> AddProductAsync(ProductDto productDto, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для удаления товара.
    /// </summary>
    /// <param name="productId">Идентификатор товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteProductAsync(int productId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения товара.
    /// </summary>
    /// <param name="productEntity">Модель представления товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateProductAsync(ProductDto productDto, CancellationToken cancellationToken);
}