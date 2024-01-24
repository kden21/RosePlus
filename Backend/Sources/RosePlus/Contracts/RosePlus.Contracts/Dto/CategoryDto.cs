namespace RosePlus.Contracts.Dto;

/// <summary>
/// Модель представленя категории.
/// </summary>
public class CategoryDto
{
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public int? Id { get; set; }
    
    /// <summary>
    /// Название категории.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Идентификатор родительской категории.
    /// </summary>
    public int? ParentCategoryId { get; set; }
}