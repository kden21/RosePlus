namespace RosePlus.Domain.Entities;

/// <summary>
/// Сущность атрибута.
/// </summary>
public class AttributeEntity : BaseEntity
{
    /// <summary>
    /// Название атрибута.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Коллекция связанных категорий атрибута.
    /// </summary>
    public ICollection<CategoryEntity> Categories { get; set; }
    
    /// <summary>
    /// Коллекция значений атрибута.
    /// </summary>
    public ICollection<AttributeValueEntity> AttributeValues { get; set; }
}