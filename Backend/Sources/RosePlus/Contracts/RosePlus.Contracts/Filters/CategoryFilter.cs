namespace RosePlus.Contracts.Filters;

/// <summary>
/// Параметры для фильтрации категорий.
/// </summary>
public class CategoryFilter : BaseFilter
{
    /// <summary>
    /// Идентификатор родительской категории.
    /// </summary>
    public int? ParentCategoryId { get; set; }
}