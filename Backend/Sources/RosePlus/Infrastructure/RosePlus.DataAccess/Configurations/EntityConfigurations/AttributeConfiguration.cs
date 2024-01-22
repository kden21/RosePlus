using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class AttributeConfiguration : IEntityTypeConfiguration<AttributeEntity>
{
    public void Configure(EntityTypeBuilder<AttributeEntity> builder)
    {
        builder.ToTable("Attributes");
    
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
    
        builder.Property(a => a.Name).HasMaxLength(400);
        
        builder.Property(a => a.CreateDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
        builder.Property(a => a.ModifyDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");

        builder.HasMany(a => a.Categories)
            .WithMany(c => c.Attributes)
            .UsingEntity(b => b.ToTable("Category_Attribute"));
    }
}