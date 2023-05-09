namespace RosePlus.Domain.Entities;

/// <summary>
/// Сущность категории.
/// </summary>
public class CategoryEntity : BaseEntity
{
    /// <summary>
    /// Название категории.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Идентификатор родительской категории.
    /// </summary>
    public int? ParentCategoryId { get; set; }
    
    /// <summary>
    /// Родительская категория.
    /// </summary>
    public CategoryEntity? ParentCategory { get; set; }
    
    /// <summary>
    /// Коллекция подкатегорий.
    /// </summary>
    public ICollection<CategoryEntity> ChildCategories { get; set; }

    /// <summary>
    /// Список товаров.
    /// </summary>
    public List<ProductEntity> Products { get; set; }
    
    /// <summary>
    /// Список атрибутов.
    /// </summary>
    public ICollection<AttributeEntity> Attributes { get; set; }
    
}