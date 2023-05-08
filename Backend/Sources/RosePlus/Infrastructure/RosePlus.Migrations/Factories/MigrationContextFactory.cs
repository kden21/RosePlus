using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RosePlus.Migrations.Factories;

public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationsDbContext>
{
    private const string ConnectionStringName = "RosePlusDB";
    
    public MigrationsDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MigrationsDbContext>();
        
        //получаем конфигурацию из appsettings.json
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        IConfigurationRoot config = builder.Build();
        
        //получаем строку подключения из appsettings.json
        string? connectionString = config.GetConnectionString(ConnectionStringName);
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException(
                $"Не найдена строка поключения с именем '{ConnectionStringName}'");
        }
        
        optionsBuilder.UseNpgsql(connectionString, opts => 
            opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
        
        return new MigrationsDbContext(optionsBuilder.Options);
    }
}