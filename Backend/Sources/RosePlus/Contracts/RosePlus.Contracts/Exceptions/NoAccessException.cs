namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Ошибка доступа.
/// </summary>
[Serializable]
public class NoAccessException: Exception
{
    public NoAccessException(string message)
        : base(message)
    {
    }
}