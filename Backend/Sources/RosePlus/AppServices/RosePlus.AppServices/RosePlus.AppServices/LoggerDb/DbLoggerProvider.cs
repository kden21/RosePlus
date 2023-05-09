using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace RosePlus.AppServices.LoggerDb;

/*[ProviderAlias("Database")]
public class DbLoggerProvider : ILoggerProvider
{
    public readonly DbLoggerOptions _dbLoggerOptions;

    public DbLoggerProvider(IOptions<DbLoggerOptions> dbLoggerOptions)
    {
        _dbLoggerOptions = dbLoggerOptions.Value; 
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new DbLogger();
    }
    
    public void Dispose() {}
}*/