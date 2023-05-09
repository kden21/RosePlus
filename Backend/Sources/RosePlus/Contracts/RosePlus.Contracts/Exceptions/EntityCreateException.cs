using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Сущность не была добавлена в БД.
/// </summary>
[Serializable]
public class EntityCreateException : BaseException
{
    public EntityCreateException(string message)
        : base(ExceptionUserMessage.EntityCreate, message)
    {
    }
}