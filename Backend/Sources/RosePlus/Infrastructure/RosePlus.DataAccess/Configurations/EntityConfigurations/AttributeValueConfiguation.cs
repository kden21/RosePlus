using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class AttributeValueConfiguration : IEntityTypeConfiguration<AttributeValueEntity>
{
    public void Configure(EntityTypeBuilder<AttributeValueEntity> builder)
    {
        builder.ToTable("AttributeValues");
    
        builder.HasKey(av => av.Id);
        builder.Property(av => av.Id).ValueGeneratedOnAdd();
    
        builder.Property(av => av.Value).HasMaxLength(400);
        
        builder.Property(av => av.CreateDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
        builder.Property(av => av.ModifyDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");

        builder.HasOne(av => av.Attribute)
            .WithMany(av => av.AttributeValues)
            .HasForeignKey(av => av.AttributeId);
    }
}