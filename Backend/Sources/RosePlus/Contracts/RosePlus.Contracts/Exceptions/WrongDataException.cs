using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Неверные данные.
/// </summary>
[Serializable]
public class WrongDataException : BaseException
{
    public WrongDataException(string logMessage)
        : base(logMessage, ExceptionUserMessage.WrongData)
    {
    }
}