namespace RosePlus.Contracts.Dto;

public class AttributeValueDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Значение атрибута.
    /// </summary>
    public string Value { get; set; }
    
    /// <summary>
    /// Идентификатор атрибута.
    /// </summary>
    public int AttributeId { get; set; }
    
    /// <summary>
    /// Идентификатор товара.
    /// </summary>
    public int ProductId { get; set; }
}