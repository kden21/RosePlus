using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        builder.ToTable("Categories");
    
        builder.HasKey(category => category.Id);
        builder.Property(category => category.Id).ValueGeneratedOnAdd();
    
        builder.Property(category => category.Name).HasMaxLength(400);
        builder.Property(category => category.CreateDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
        builder.Property(category => category.ModifyDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");

        builder.HasMany(category => category.Products)
            .WithOne(product => product.Category)
            .HasForeignKey(product => product.CategoryId);

        builder.HasOne(chc => chc.ParentCategory)
            .WithMany(pc => pc.ChildCategories)
            .HasForeignKey(chc => chc.ParentCategoryId);

    }
}