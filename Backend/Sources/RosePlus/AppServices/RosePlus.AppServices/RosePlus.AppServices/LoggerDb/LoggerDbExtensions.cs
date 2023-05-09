using Microsoft.Extensions.Logging;
using RosePlus.AppServices.Repositories;

namespace RosePlus.AppServices.LoggerDb;

public static class LoggerDbExtensions
{
    private static readonly ILoggerDbRepository _loggerDbRepository;
    public static ILoggingBuilder AddDatabase(this ILoggingBuilder builder)
    {
        builder.AddProvider(new LoggerDbProvider(_loggerDbRepository));
        return builder;
    }
}