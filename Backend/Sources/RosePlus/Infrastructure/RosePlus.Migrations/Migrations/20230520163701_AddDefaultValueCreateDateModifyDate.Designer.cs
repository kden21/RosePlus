﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RosePlus.Migrations;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    [DbContext(typeof(MigrationsDbContext))]
    [Migration("20230520163701_AddDefaultValueCreateDateModifyDate")]
    partial class AddDefaultValueCreateDateModifyDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AttributeEntityCategoryEntity", b =>
                {
                    b.Property<int>("AttributesId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.HasKey("AttributesId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Category_Attribute", (string)null);
                });

            modelBuilder.Entity("AttributeValueEntityProductEntity", b =>
                {
                    b.Property<int>("AttributeValuesId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("AttributeValuesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("Product_AttributeValue", (string)null);
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.AttributeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<DateTime>("ModifyDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.HasKey("Id");

                    b.ToTable("Attributes", (string)null);
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.AttributeValueEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AttributeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<DateTime>("ModifyDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("AttributeValues", (string)null);
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<DateTime>("ModifyDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime>("ModifyDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'UTC'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("AttributeEntityCategoryEntity", b =>
                {
                    b.HasOne("RosePlus.Domain.Entities.AttributeEntity", null)
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RosePlus.Domain.Entities.CategoryEntity", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AttributeValueEntityProductEntity", b =>
                {
                    b.HasOne("RosePlus.Domain.Entities.AttributeValueEntity", null)
                        .WithMany()
                        .HasForeignKey("AttributeValuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RosePlus.Domain.Entities.ProductEntity", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.AttributeValueEntity", b =>
                {
                    b.HasOne("RosePlus.Domain.Entities.AttributeEntity", "Attribute")
                        .WithMany("AttributeValues")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.CategoryEntity", b =>
                {
                    b.HasOne("RosePlus.Domain.Entities.CategoryEntity", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.ProductEntity", b =>
                {
                    b.HasOne("RosePlus.Domain.Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.AttributeEntity", b =>
                {
                    b.Navigation("AttributeValues");
                });

            modelBuilder.Entity("RosePlus.Domain.Entities.CategoryEntity", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
