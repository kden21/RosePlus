using Microsoft.EntityFrameworkCore;
using RosePlus.DataAccess.Configurations.EntityConfigurations;
using RosePlus.DataAccess.Configurations.EntityConfigurations.Files;

namespace RosePlus.DataAccess.Context;

public class RosePlusContext : DbContext
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="RosePlusContext"/>>
    /// </summary>
    /// <param name="options"></param>
    public RosePlusContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration())
            .ApplyConfiguration(new CategoryConfiguration())
            .ApplyConfiguration(new AttributeConfiguration())
            .ApplyConfiguration(new AttributeValueConfiguration())
            .ApplyConfiguration(new FileConfiguration())
            /*.ApplyConfiguration(new ProductFileConfiguration())*/;
    }
}