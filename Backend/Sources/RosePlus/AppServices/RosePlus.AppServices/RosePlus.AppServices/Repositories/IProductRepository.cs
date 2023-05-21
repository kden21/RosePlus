using RosePlus.Contracts.Filters;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

/// <summary>
/// Репозиторий для работы с товаром.
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// Метод получения товара по идентификатору.
    /// </summary>
    /// <param name="productId">Идентификатор товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Сущность товара.</returns>
    Task<ProductEntity> GetProductById(int productId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для получения коллекции товаров по фильтру.
    /// </summary>
    /// <param name="productFilter">Параметры фильтрации.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Коллекция сущностей товаров.</returns>
    Task<List<ProductEntity>> GetProducts(ProductFilter productFilter, CancellationToken cancellationToken);

    /// <summary>
    /// Метод добавления товара.
    /// </summary>
    /// <param name="productEntity">Сущность товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Иденификатор товара.</returns>
    Task<int> AddProduct(ProductEntity productEntity, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для удаления товара.
    /// </summary>
    /// <param name="productId">Идентификатор товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteProduct(int productId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения товара.
    /// </summary>
    /// <param name="productEntity">Модель представления товара.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateProduct(ProductEntity productEntity, CancellationToken cancellationToken);
}