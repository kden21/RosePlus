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
    
    public ICollection<AttributeValueEntity> AttributeValues { get; set; }
}