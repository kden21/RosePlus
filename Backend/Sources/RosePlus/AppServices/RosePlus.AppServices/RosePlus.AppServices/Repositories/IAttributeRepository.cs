using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

public interface IAttributeRepository
{
    /// <summary>
    /// Метод получения атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeId">Идентификатор атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Сущность атрибута.</returns>
    Task<AttributeEntity> GetAttributeById(int attributeId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для получения атрибутов по фильтру.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Список атрибутов.</returns>
    Task<List<AttributeEntity>> GetAttributes(CancellationToken cancellationToken);

    /// <summary>
    /// Метод добавления атрибута.
    /// </summary>
    /// <param name="attributeEntity">Модель атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Идентификатор атрибута.</returns>
    Task<int> AddAttribute(AttributeEntity attributeEntity, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для удаления атрибута.
    /// </summary>
    /// <param name="attributeId">Идентификатор значения атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteAttribute(int attributeId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения атрибута.
    /// </summary>
    /// <param name="attributeEntity">Модель атрибута.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateAttribute(AttributeEntity attributeEntity, CancellationToken cancellationToken);
}