namespace RosePlus.Contracts.Exceptions;

public class BaseException : Exception
{
    /// <summary>
    /// Сообщение исключения для записи в лог.
    /// </summary>
    public string UserMessage { get; }
    
    public BaseException(string logMessage, string userMessage)
        : base(logMessage)
    {
        UserMessage = userMessage;
    }
}