using Microsoft.Extensions.Logging;

namespace RosePlus.AppServices;

public static class LoggerDbExtensions
{
    public static ILoggingBuilder AddDatabase(this ILoggingBuilder builder)
    {
        builder.AddProvider(new LoggerDbProvider());
        return builder;
    }
}