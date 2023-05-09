using Microsoft.Extensions.Logging;

namespace RosePlus.AppServices;

public class LoggerDbService : ILogger, IDisposable
{
    static object _lock = new object();
    
    public LoggerDbService()
    {
        
    }
    public IDisposable BeginScope<TState>(TState state)
    {
        return this;
    }
 
    public void Dispose() { }
 
    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }
 
    public void Log<TState>(
        LogLevel logLevel, 
        EventId eventId,
        TState state, 
        Exception? exception, 
        Func<TState, Exception?, string> formatter)
    {
        
    }
}