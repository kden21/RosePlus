namespace RosePlus.Contracts.ApiResult;

/// <summary>
/// Ошибка.
/// </summary>
public class ApiError
{
    /// <summary>
    /// Содержание ошибки.
    /// </summary>
    public string Message { get; set; }
    
    /*/// <summary>
    /// Уровень ошибки.
    /// </summary>
    public ApiErrorLevel ApiErrorLevel { get; set; }*/
    
    /// <summary>
    /// Идентификатор операции.
    /// </summary>
    public string TraceId { get; set; }
}