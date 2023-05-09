using Microsoft.Extensions.Logging;

namespace RosePlus.AppServices;

public class LoggerDbProvider : ILoggerProvider
{
    
    public LoggerDbProvider()
    {
        
    }
    
    public ILogger CreateLogger(string categoryName)
    {
        return new LoggerDbService();
    }
 
    public void Dispose() {}
}