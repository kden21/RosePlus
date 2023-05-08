namespace RosePlus.Domain.Entities;

public class RoseItemEntity : ProductEntity
{
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public int CategoryId { get; set; }
    
    /// <summary>
    /// Категория.
    /// </summary>
    public CategoryEntity Category { get; set; }
}