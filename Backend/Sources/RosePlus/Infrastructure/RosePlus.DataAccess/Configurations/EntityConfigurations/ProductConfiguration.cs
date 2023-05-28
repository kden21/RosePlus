using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.ToTable("Products");
        
        builder.HasKey(product => product.Id);
        builder.Property(product => product.Id).ValueGeneratedOnAdd();
        
        builder.Property(product => product.Name).HasMaxLength(100);
        builder.Property(product => product.Description).HasMaxLength(1000);
        builder.Property(product => product.CreateDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
        builder.Property(product => product.ModifyDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");

        builder.HasOne(product => product.Category)
            .WithMany(category => category.Products)
            .HasForeignKey(product => product.CategoryId);

        builder.HasMany(p => p.AttributeValues)
            .WithOne(av => av.Product)
            .HasForeignKey(p => p.ProductId);
    }
}