using RosePlus.Contracts.Exceptions.ExceptionMessage;

namespace RosePlus.Contracts.Exceptions;

/// <summary>
/// Исключение: Сущность не была найдена.
/// </summary>
[Serializable]
public class EntityNotFoundException : BaseException
{
    public EntityNotFoundException(string message)
        : base(ExceptionUserMessage.EntityCreate ,message)
    {
    }
}