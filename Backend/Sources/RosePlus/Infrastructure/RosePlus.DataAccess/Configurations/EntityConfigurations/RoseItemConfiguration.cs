using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class RoseItemConfiguration : IEntityTypeConfiguration<RoseItemEntity>
{
    public void Configure(EntityTypeBuilder<RoseItemEntity> builder)
    {
        builder.ToTable("RoseItems");
        
        builder.HasKey(roseItem => roseItem.Id);
        builder.Property(roseItem => roseItem.Id).ValueGeneratedOnAdd();
        
        builder.Property(roseItem => roseItem.Name).HasMaxLength(100);
        builder.Property(roseItem => roseItem.Description).HasMaxLength(1000);

        builder.HasOne(roseItem => roseItem.Category)
            .WithMany(category => category.RoseItems)
            .HasForeignKey(roseItem => roseItem.CategoryId);
    }
}