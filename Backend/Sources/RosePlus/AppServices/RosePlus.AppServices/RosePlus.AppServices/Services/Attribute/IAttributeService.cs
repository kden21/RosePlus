using RosePlus.Contracts.Dto;

namespace RosePlus.AppServices.Services.Attribute;

/// <summary>
/// Сервис для работы с атрибутами.
/// </summary>
public interface IAttributeService
{
    /// <summary>
    /// Метод для получения атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeId">Идентификатор атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Атрибут.</returns>
    Task<AttributeDto> GetAttributeByIdAsync(int attributeId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для получения коллекции атрибутов.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Коллекция атрибутов.</returns>
    Task<IEnumerable<AttributeDto>> GetAttributesAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод добавления атрибута.
    /// </summary>
    /// <param name="attributeDto">Модель представления атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Идентификатор атрибута.</returns>
    Task<int> AddAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken);
    
    /// <summary>
    /// Метод для удаления атрибута.
    /// </summary>
    /// <param name="attributeId">Идентификатор атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteAttributeAsync(int attributeId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения атрибута.
    /// </summary>
    /// <param name="attributeDto">Модель представления атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken);
}