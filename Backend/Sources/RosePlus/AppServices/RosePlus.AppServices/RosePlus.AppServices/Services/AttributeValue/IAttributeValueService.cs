using RosePlus.Contracts.Dto;

namespace RosePlus.AppServices.Services.AttributeValue;

/// <summary>
/// Сервис для работы со значениями атрибутов.
/// </summary>
public interface IAttributeValueService
{
    /// <summary>
    /// Метод для получения значения атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Значение атрибута.</returns>
    Task<AttributeValueDto> GetAttributeValueByIdAsync(int attributeValueId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для получения коллекции значений атрибута.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Коллекция значений атрибутов.</returns>
    Task<IEnumerable<AttributeValueDto>> GetAttributeValuesAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод добавления значения атрибута.
    /// </summary>
    /// <param name="attributeValueDto">Модель представления значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Идентификатор значения атрибута.</returns>
    Task<int> AddAttributeValueAsync(AttributeValueDto attributeValueDto, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для удаления значения атрибута.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteAttributeValueAsync(int attributeValueId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения значения атрибута.
    /// </summary>
    /// <param name="attributeValueDto">Модель представления значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateAttributeValueAsync(AttributeValueDto attributeValueDto, CancellationToken cancellationToken);
}