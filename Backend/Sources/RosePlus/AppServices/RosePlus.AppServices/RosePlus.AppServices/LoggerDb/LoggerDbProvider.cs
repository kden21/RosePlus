using Microsoft.Extensions.Logging;
using RosePlus.AppServices.Repositories;

namespace RosePlus.AppServices.LoggerDb;

public class LoggerDbProvider : ILoggerProvider
{
    private readonly ILoggerDbRepository _loggerDbRepository;
    public LoggerDbProvider(ILoggerDbRepository loggerDbRepository)
    {
        _loggerDbRepository = loggerDbRepository;
    }
    
    public ILogger CreateLogger(string categoryName)
    {
        return new LoggerDbService(_loggerDbRepository);
    }
 
    public void Dispose() {}
}