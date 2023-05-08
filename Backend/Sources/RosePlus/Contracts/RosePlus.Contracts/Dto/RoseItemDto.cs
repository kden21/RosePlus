namespace RosePlus.Contracts.Dto;

/// <summary>
/// Данные о розе.
/// </summary>
public class RoseItemDto : BaseDto
{
    /// <summary>
    /// Название розы.
    /// </summary>
    public string Name { get; set; } 
    
    /// <summary>
    /// Описание розы.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Стоимость розы.
    /// </summary>
    public double Price { get; set; }
    
    /// <summary>
    /// Колличество роз.
    /// </summary>
    public int Count { get; set; }
}