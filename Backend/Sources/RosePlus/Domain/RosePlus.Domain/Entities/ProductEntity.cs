namespace RosePlus.Domain.Entities;

public class ProductEntity : BaseEntity
{
    /// <summary>
    /// Название товара.
    /// </summary>
    public string Name { get; set; } 
    
    /// <summary>
    /// Описание товара.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Стоимость товара.
    /// </summary>
    public double Price { get; set; }
    
    /// <summary>
    /// Колличество товара.
    /// </summary>
    public int Count { get; set; }
}