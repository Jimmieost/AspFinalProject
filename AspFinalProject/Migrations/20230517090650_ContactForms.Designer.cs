﻿// <auto-generated />
using System;
using AspFinalProject.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspFinalProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230517090650_ContactForms")]
    partial class ContactForms
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspFinalProject.Models.Entities.AccountEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AspFinalProject.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Featured"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Popular"
                        });
                });

            modelBuilder.Entity("AspFinalProject.Models.Entities.ContactEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("AspFinalProject.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Pearl Export EXX is a popular drumkit among beginner and intermediate drummers. It features high-quality hardware and comes in a variety of finishes.",
                            Image = "1.png",
                            Name = "Pearl Export EXX",
                            Price = 799m
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Ludwig Classic Maple is a professional-grade drumkit that has been used by many famous drummers. It is known for its warm tone and great projection.",
                            Image = "2.png",
                            Name = "Ludwig Classic Maple",
                            Price = 2699m
                        },
                        new
                        {
                            Id = 3,
                            Description = "The DW Design Series is a versatile drumkit that is suitable for a wide range of musical styles. It features a low-mass tom suspension system for enhanced resonance.",
                            Image = "3.png",
                            Name = "DW Design Series",
                            Price = 1899m
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Gretsch Catalina Club is a compact drumkit that is ideal for smaller venues and practice spaces. It features a vintage-style design and comes in several colors.",
                            Image = "4.png",
                            Name = "Gretsch Catalina Club",
                            Price = 799m
                        },
                        new
                        {
                            Id = 5,
                            Description = "The Mapex Saturn V is a high-end drumkit that offers excellent sound quality and durability. It features hybrid shells made from maple and walnut.",
                            Image = "5.png",
                            Name = "Mapex Saturn V",
                            Price = 1999m
                        },
                        new
                        {
                            Id = 6,
                            Description = "The PDP Concept Maple is a versatile drumkit that is suitable for a wide range of musical styles. It features a maple shell and comes in several finishes.",
                            Image = "6.png",
                            Name = "PDP Concept Maple",
                            Price = 999m
                        },
                        new
                        {
                            Id = 7,
                            Description = "The Tama Imperialstar is a popular drumkit among beginner and intermediate drummers. It features a 100% poplar shell and comes in several finishes.",
                            Image = "7.png",
                            Name = "Tama Imperialstar",
                            Price = 799m
                        },
                        new
                        {
                            Id = 8,
                            Description = "The Sonor AQ2 is a mid-range drumkit that offers excellent sound quality and versatility. It features a maple shell and comes in several finishes.",
                            Image = "8.png",
                            Name = "Sonor AQ2",
                            Price = 1299m
                        },
                        new
                        {
                            Id = 9,
                            Description = "The Yamaha Stage Custom is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "9.png",
                            Name = "Yamaha Stage Custom",
                            Price = 699m
                        },
                        new
                        {
                            Id = 10,
                            Description = "The Pearl Popstar is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "10.png",
                            Name = "Pearl Popstar",
                            Price = 699m
                        },
                        new
                        {
                            Id = 11,
                            Description = "The Yamaha Legend is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "11.png",
                            Name = "Yamaha Legend",
                            Price = 699m
                        },
                        new
                        {
                            Id = 12,
                            Description = "The Gretch California is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "12.png",
                            Name = "Gretch California",
                            Price = 699m
                        },
                        new
                        {
                            Id = 13,
                            Description = "The Mapex SXX is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "13.png",
                            Name = "Mapex SXX",
                            Price = 699m
                        },
                        new
                        {
                            Id = 14,
                            Description = "The Yamaha Stage Custom is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "14.png",
                            Name = "Gretch Fall Out",
                            Price = 699m
                        },
                        new
                        {
                            Id = 15,
                            Description = "The Premier Beatles Signature is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "15.png",
                            Name = "Premier Beatles Signature",
                            Price = 699m
                        },
                        new
                        {
                            Id = 16,
                            Description = "The Pearl Olympic is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "16.png",
                            Name = "Pearl Olympic",
                            Price = 699m
                        },
                        new
                        {
                            Id = 17,
                            Description = "The Tama Ulrich Signature is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "17.png",
                            Name = "Tama Ulrich Signature",
                            Price = 699m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Gretch Solar is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "18.png",
                            Name = "Gretch Solar",
                            Price = 699m
                        },
                        new
                        {
                            Id = 19,
                            Description = "The Yamaha DKV is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "19.png",
                            Name = "Yamaha DKV ",
                            Price = 999m
                        },
                        new
                        {
                            Id = 20,
                            Description = "The Yamaha DTX is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.",
                            Image = "20.png",
                            Name = "Yamaha DTX",
                            Price = 599m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b7ef0e5a-03e9-4911-aed0-7bfb3d933ea9",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "162e097a-402e-41b2-b016-558a193e1138",
                            Name = "customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProductCategory", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 3
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 4
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 5
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 6
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 7
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 8
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 9
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 10
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 6
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 7
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 8
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 9
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 10
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 15
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 15
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 16
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 17
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 18
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 19
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 20
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AspFinalProject.Models.Entities.AccountEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AspFinalProject.Models.Entities.AccountEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspFinalProject.Models.Entities.AccountEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AspFinalProject.Models.Entities.AccountEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductCategory", b =>
                {
                    b.HasOne("AspFinalProject.Models.Entities.CategoryEntity", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspFinalProject.Models.Entities.ProductEntity", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
