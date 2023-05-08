using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class AttributeValueConfiguration : IEntityTypeConfiguration<AttributeValueEntity>
{
    public void Configure(EntityTypeBuilder<AttributeValueEntity> builder)
    {
        builder.ToTable("AttributeValues")
            .HasIndex(a => a.Id).IsUnique();
    
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
    
        builder.Property(a => a.Value).HasMaxLength(400);

        builder.HasOne(av => av.Attribute)
            .WithMany(a => a.AttributeValues)
            .HasForeignKey(a => a.AttributeId);
    }
}