using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Сущность не была обновлена.
/// </summary>
[Serializable]
public class EntityUpdateException : BaseException
{
    public EntityUpdateException(string logMessage)
        : base(logMessage, ExceptionUserMessage.EntityUpdate)
    {
    }
}