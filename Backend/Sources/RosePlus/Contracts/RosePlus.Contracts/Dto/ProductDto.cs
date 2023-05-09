namespace RosePlus.Contracts.Dto;

/// <summary>
/// Данные о товаре.
/// </summary>
public class ProductDto : BaseDto
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
    
    public int CategoryId { get; set; }
}