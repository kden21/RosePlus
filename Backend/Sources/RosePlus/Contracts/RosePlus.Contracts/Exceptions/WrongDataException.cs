namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Неверные данные.
/// </summary>
[Serializable]
public class WrongDataException : Exception
{
    public WrongDataException(string message)
        : base(message)
    {
    }
}