namespace RosePlus.Domain.Entities;

/// <summary>
/// Базовая сущность.
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор сущности.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Дата создания сущности.
    /// </summary>
    public DateTime CreateDate {get; set; }
    
    /// <summary>
    /// Помледняя дата модификции сущности.
    /// </summary>
    public DateTime ModifyDate { get; set; }
}