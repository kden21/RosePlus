namespace RosePlus.Domain.Entities;

/// <summary>
/// Сущность значения атрибута.
/// </summary>
public class AttributeValueEntity : BaseEntity
{
    /// <summary>
    /// Значение атрибута.
    /// </summary>
    public string Value { get; set; }
    
    /// <summary>
    /// Идентификатор атрибута.
    /// </summary>
    public int AttributeId { get; set; }
    
    /// <summary>
    /// Атрибут.
    /// </summary>
    public AttributeEntity Attribute { get; set; }
    
    public ICollection<ProductEntity> Products { get; set; }
}