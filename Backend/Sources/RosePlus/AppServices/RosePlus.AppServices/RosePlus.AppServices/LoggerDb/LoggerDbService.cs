using Microsoft.Extensions.Logging;
using RosePlus.AppServices.Repositories;
using RosePlus.AppServices.Services;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.LoggerDb;

public class LoggerDbService : ILogger, IDisposable
{
    private readonly ILoggerDbRepository _loggerDbRepository;
    //private readonly IProductService _productService;
    public LoggerDbService(ILoggerDbRepository loggerDbRepository)
    {
        _loggerDbRepository = loggerDbRepository;
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
        var e = new LogEntity();
        _loggerDbRepository.AddLog(e, CancellationToken.None);
    }
}