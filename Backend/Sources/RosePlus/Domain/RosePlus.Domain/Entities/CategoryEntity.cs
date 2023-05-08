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
    /// Список роз данной категории.
    /// </summary>
    public List<RoseItemEntity> RoseItems { get; set; }
}