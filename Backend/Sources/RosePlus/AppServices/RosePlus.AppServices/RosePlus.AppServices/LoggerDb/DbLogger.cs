using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace RosePlus.AppServices.LoggerDb;

/*public class DbLogger : ILogger
{
    private readonly DbLoggerProvider _dbLoggerProvider;

    public DbLogger([NotNull]DbLoggerProvider dbLoggerProvider)
    {
        _dbLoggerProvider = dbLoggerProvider;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel))
        {
            return;
        }

        var threadId = Thread.CurrentThread.ManagedThreadId;

        using ()
        {
            
        }
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        throw new NotImplementedException();
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }
}*/