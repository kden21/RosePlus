using RosePlus.Contracts.Enums;
using RosePlus.Domain.Entities.Files;

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
    
    /// <summary>
    /// Статус товара.
    /// </summary>
    public StatusProduct Status { get; set; }
    
    /// <summary>
    /// Идентификатор категории товара.
    /// </summary>
    public int CategoryId { get; set; }
    
    /// <summary>
    /// Категория товара.
    /// </summary>
    public CategoryEntity Category { get; set; }
    
    /// <summary>
    /// Коллекция значений атрибутов.
    /// </summary>
    public ICollection<AttributeValueEntity> AttributeValues { get; set; }
    
    /// <summary>
    /// Коллекция фотографий.
    /// </summary>
    public ICollection<FileEntity> Photos  { get; set; }
}