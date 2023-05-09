using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Ошибка доступа.
/// </summary>
[Serializable]
public class NoAccessException: BaseException
{
    public NoAccessException(string logMessage)
        : base(logMessage, ExceptionUserMessage.NoAccess)
    {
    }
}