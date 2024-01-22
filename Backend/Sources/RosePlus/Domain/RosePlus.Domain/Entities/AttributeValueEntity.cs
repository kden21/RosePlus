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
    
    /// <summary>
    /// Идентификатор товара.
    /// </summary>
    public int ProductId { get; set; }
    
    /// <summary>
    /// Товар.
    /// </summary>
    public ProductEntity Product { get; set; }
}