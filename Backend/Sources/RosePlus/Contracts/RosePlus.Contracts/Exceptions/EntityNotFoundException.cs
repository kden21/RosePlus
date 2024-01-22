using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Сущность не была найдена.
/// </summary>
[Serializable]
public class EntityNotFoundException : BaseException
{
    public EntityNotFoundException(string logMessage)
        : base(logMessage, ExceptionUserMessage.EntityNotFound)
    {
    }
}