using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RosePlus.Common;

namespace RosePlus.Migrations.Factories;

public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationsDbContext>
{
    private const string _connectionStringName = "RosePlusDB";

    public MigrationsDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MigrationsDbContext>();

        var config = AppConfiguration.Current;
        
        //получаем строку подключения из appsettings.json
        string? connectionString = config.GetConnectionString(_connectionStringName);

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException(
                $"Не найдена строка поключения с именем '{_connectionStringName}'");
        }
        
        optionsBuilder.UseNpgsql(connectionString, opts => 
            opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
        
        return new MigrationsDbContext(optionsBuilder.Options);
    }
}