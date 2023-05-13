using Microsoft.Extensions.Configuration;

namespace RosePlus.Common;

public class AppConfiguration
{
    private static IConfigurationRoot _configuration;
    
    public static IConfigurationRoot Current
    {
        get { return _configuration ??= GetCurrentConfiguration(); }
    }

    private static IConfigurationRoot GetCurrentConfiguration()
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var appSettingsName = string.IsNullOrEmpty(environment) ? "appsettings.json" : $"appsettings.{environment}.json";
        
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(appSettingsName, optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}