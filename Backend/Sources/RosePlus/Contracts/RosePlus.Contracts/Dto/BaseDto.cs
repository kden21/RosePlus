namespace RosePlus.Contracts.Dto;

/// <summary>
/// Базовая Dto.
/// </summary>
public class BaseDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Дата создания.
    /// </summary>
    public string CreateDate { get; set; } 
    
    /// <summary>
    /// Дата последнего изменения.
    /// </summary>
    public string ModifyDate { get; set; }
}