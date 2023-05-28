using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

public interface IAttributeValueRepository
{
    /// <summary>
    /// Метод получения значений атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Сущность значения атрибута.</returns>
    Task<AttributeValueEntity> GetAttributeValueById(int attributeValueId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для получения всех значений атрибута по фильтру.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Список значений атрибута.</returns>
    Task<List<AttributeValueEntity>> GetAttributeValues(CancellationToken cancellationToken);

    /// <summary>
    /// Метод добавления значения атрибута.
    /// </summary>
    /// <param name="attributeValueEntity">Модель значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Иденификатор значения атрибута.</returns>
    Task<int> AddAttributeValue(AttributeValueEntity attributeValueEntity, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для удаления значения атрибута.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteAttributeValue(int attributeValueId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения значения атрибута.
    /// </summary>
    /// <param name="attributeValueEntity">Модель значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateAttributeValue(AttributeValueEntity attributeValueEntity, CancellationToken cancellationToken);
}