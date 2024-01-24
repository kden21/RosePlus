namespace RosePlus.Contracts.Filters;

/// <summary>
/// Базовый фильтр.
/// </summary>
public class BaseFilter
{
    /// <summary>
    /// Количество извлекаемых элементов.
    /// </summary>
    public int? Count { get; set; }
    
    /// <summary>
    /// Количество пропускаемых элементов.
    /// </summary>
    public int? Skip { get; set; }
}