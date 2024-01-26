using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RosePlus.Domain.Entities.Files;

namespace RosePlus.DataAccess.Configurations.EntityConfigurations.Files;

public class FileConfiguration : IEntityTypeConfiguration<FileEntity>
{
    public void Configure(EntityTypeBuilder<FileEntity> builder)
    {
        builder.ToTable("Files");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();

        builder.Property(a => a.Name).HasMaxLength(400);
        builder.Property(a => a.Extension).HasMaxLength(100);
        builder.Property(a => a.Path).HasMaxLength(200);

        builder.Property(a => a.CreateDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
        builder.Property(a => a.ModifyDate).HasDefaultValueSql("current_timestamp at time zone 'UTC'");
    }
}
    
