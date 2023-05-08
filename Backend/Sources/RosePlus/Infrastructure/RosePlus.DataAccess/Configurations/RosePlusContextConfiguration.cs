using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RosePlus.DataAccess.Configurations.Interfaces;
using RosePlus.DataAccess.Context;

namespace RosePlus.DataAccess.Configurations;

public class RosePlusContextConfiguration : IDbContextOptionsConfigurator<RosePlusContext>
{
    private const string ConnectionStringName = "RosePlusDB";
    private readonly IConfiguration _configuration;
    private readonly ILoggerFactory _loggerFactory; 

    public RosePlusContextConfiguration(IConfiguration configuration, ILoggerFactory loggerFactory)
    {
        _configuration = configuration;
        _loggerFactory = loggerFactory;
    }

    public void Configure(DbContextOptionsBuilder<RosePlusContext> options)
    {
        var connectionString = _configuration.GetConnectionString(ConnectionStringName);

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException(
                $"Не найдена строка поключения с именем '{ConnectionStringName}'");
        }

        options.UseNpgsql(connectionString)
            .UseLoggerFactory(_loggerFactory);
    }
}