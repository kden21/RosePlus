using Microsoft.EntityFrameworkCore;
using RosePlus.DataAccess.Configurations.EntityConfigurations;

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
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new AttributeConfiguration());
        modelBuilder.ApplyConfiguration(new AttributeValueConfiguration());
    }
}