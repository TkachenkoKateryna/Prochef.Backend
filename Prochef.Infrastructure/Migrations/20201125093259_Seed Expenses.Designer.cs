﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prochef.Infrastructure.EF;

namespace Prochef.Infrastructure.Migrations
{
    [DbContext(typeof(ProchefDbContext))]
    [Migration("20201125093259_Seed Expenses")]
    partial class SeedExpenses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prochef.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Chain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Chains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Kharkov",
                            Country = "Ukraine",
                            IsDeleted = false,
                            Name = "Macdonalds"
                        },
                        new
                        {
                            Id = 2,
                            City = "Kharkov",
                            Country = "Ukraine",
                            IsDeleted = false,
                            Name = "KFC"
                        },
                        new
                        {
                            Id = 3,
                            City = "Kharkov",
                            Country = "Ukraine",
                            IsDeleted = false,
                            Name = "BurgerKing"
                        });
                });

            modelBuilder.Entity("Prochef.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Expenses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UsedQuantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.10000000000000001
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.10000000000000001
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.10000000000000001
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.10000000000000001
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "IceCream",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.25
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.25
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.25
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "IceCream",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "IceCream",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.14999999999999999
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.14999999999999999
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.20000000000000001
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.5
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.5
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "IceCream",
                            UsedQuantity = 0.25
                        },
                        new
                        {
                            Id = 26,
                            Date = new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Potato",
                            UsedQuantity = 0.29999999999999999
                        },
                        new
                        {
                            Id = 27,
                            Date = new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "IceCream",
                            UsedQuantity = 0.25
                        },
                        new
                        {
                            Id = 28,
                            Date = new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ProductName = "Meet",
                            UsedQuantity = 0.40000000000000002
                        });
                });

            modelBuilder.Entity("Prochef.Core.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasFilter("[Title] IS NOT NULL");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Title = "Macdonalds Menu"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Title = "KFC Menu"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Title = "BurgerKing Menu"
                        });
                });

            modelBuilder.Entity("Prochef.Core.Entities.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Prochef.Core.Entities.MenuSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("MenuSections");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("QuantityInStock")
                        .HasColumnType("float");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<double>("TermOfUse")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlaceId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Prochef.Core.Entities.ProductListItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductListItems");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChainId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChainId");

                    b.HasIndex("MenuId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "str. Sumskaya 4",
                            ChainId = 1,
                            IsDeleted = false,
                            MenuId = 1,
                            Name = "Macdonals",
                            Phone = "+3800996844514"
                        },
                        new
                        {
                            Id = 2,
                            Address = "str. Beketova 4",
                            ChainId = 1,
                            IsDeleted = false,
                            MenuId = 1,
                            Name = "Macdonals",
                            Phone = "+38009234314"
                        },
                        new
                        {
                            Id = 3,
                            Address = "str. Beketova 24",
                            ChainId = 2,
                            IsDeleted = false,
                            MenuId = 2,
                            Name = "KFC",
                            Phone = "+380096523214"
                        },
                        new
                        {
                            Id = 4,
                            Address = "str. Studencheskay 24",
                            ChainId = 3,
                            IsDeleted = false,
                            MenuId = 3,
                            Name = "BurgerKing",
                            Phone = "+380099345514"
                        });
                });

            modelBuilder.Entity("Prochef.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Chef"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Cook"
                        });
                });

            modelBuilder.Entity("Prochef.Core.Entities.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DeliveryTime")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Prochef.Core.Entities.VendorCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "VendorId");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorCategories");
                });

            modelBuilder.Entity("Prochef.Core.Entities.Employee", b =>
                {
                    b.HasOne("Prochef.Core.Entities.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Prochef.Core.Entities.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Prochef.Core.Entities.Ingredient", b =>
                {
                    b.HasOne("Prochef.Core.Entities.MenuItem", "MenuItem")
                        .WithMany("Ingredients")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Prochef.Core.Entities.Product", "Product")
                        .WithMany("Ingredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Prochef.Core.Entities.MenuItem", b =>
                {
                    b.HasOne("Prochef.Core.Entities.MenuSection", "Section")
                        .WithMany("MenuItems")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Prochef.Core.Entities.MenuSection", b =>
                {
                    b.HasOne("Prochef.Core.Entities.Menu", "Menu")
                        .WithMany("Sections")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Prochef.Core.Entities.Product", b =>
                {
                    b.HasOne("Prochef.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Prochef.Core.Entities.Place", "Place")
                        .WithMany("Products")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Prochef.Core.Entities.Restaurant", b =>
                {
                    b.HasOne("Prochef.Core.Entities.Chain", "Chain")
                        .WithMany("Restaurants")
                        .HasForeignKey("ChainId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Prochef.Core.Entities.Menu", "Menu")
                        .WithMany("Restaurants")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Prochef.Core.Entities.VendorCategory", b =>
                {
                    b.HasOne("Prochef.Core.Entities.Category", "Category")
                        .WithMany("VendorCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Prochef.Core.Entities.Vendor", "Vendor")
                        .WithMany("VendorCategories")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
