﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaProject;

namespace PizzaProject.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaProject.Models.Crust", b =>
                {
                    b.Property<int>("CrustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CrustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("CrustId");

                    b.ToTable("crusts");

                    b.HasData(
                        new
                        {
                            CrustId = 1,
                            CrustName = "Neapolitan",
                            Price = 3f
                        },
                        new
                        {
                            CrustId = 2,
                            CrustName = "Chicago-Deep-Dish",
                            Price = 5.5f
                        },
                        new
                        {
                            CrustId = 3,
                            CrustName = "New-Haven-Style",
                            Price = 4f
                        },
                        new
                        {
                            CrustId = 4,
                            CrustName = "Flatbread",
                            Price = 3.5f
                        });
                });

            modelBuilder.Entity("PizzaProject.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IsVeg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            IsVeg = "Yes",
                            PizzaName = "Cheese Pizza",
                            Price = 15f,
                            Remarks = "Classic Masterpiece"
                        },
                        new
                        {
                            ItemId = 2,
                            IsVeg = "Yes",
                            PizzaName = "Veggie Pizza",
                            Price = 13f,
                            Remarks = "Flavoured with Capsicum,Pepper and Onions"
                        },
                        new
                        {
                            ItemId = 3,
                            IsVeg = "No",
                            PizzaName = "Pepperoni Pizza",
                            Price = 16.5f,
                            Remarks = "Crispy,salty,round Pepperoni"
                        },
                        new
                        {
                            ItemId = 4,
                            IsVeg = "No",
                            PizzaName = "Meat Pizza",
                            Price = 18.5f,
                            Remarks = "Ground Meat with Sausage"
                        },
                        new
                        {
                            ItemId = 5,
                            IsVeg = "No",
                            PizzaName = "Margheritta Pizza",
                            Price = 18f,
                            Remarks = "Fresh Mozerilla,Basil and tomatoes"
                        },
                        new
                        {
                            ItemId = 6,
                            IsVeg = "No",
                            PizzaName = "BBQ Chicken Pizza",
                            Price = 16f,
                            Remarks = "Tangy,sweet"
                        },
                        new
                        {
                            ItemId = 7,
                            IsVeg = "No",
                            PizzaName = "Hawaiian Pizza",
                            Price = 20f,
                            Remarks = "Pineapple with ham,sweet n salty"
                        });
                });

            modelBuilder.Entity("PizzaProject.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CrustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToppingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("OrderId");

                    b.HasIndex("CustId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("PizzaProject.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("orderdetails");
                });

            modelBuilder.Entity("PizzaProject.Models.Topping", b =>
                {
                    b.Property<int>("ToppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IsVeg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ToppingName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToppingId");

                    b.ToTable("toppings");

                    b.HasData(
                        new
                        {
                            ToppingId = 1,
                            IsVeg = "Yes",
                            Price = 3f,
                            ToppingName = "Green Pepper"
                        },
                        new
                        {
                            ToppingId = 2,
                            IsVeg = "No",
                            Price = 5.5f,
                            ToppingName = "Black Olives with Chicken pieces"
                        });
                });

            modelBuilder.Entity("PizzaProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PizzaProject.Models.Order", b =>
                {
                    b.HasOne("PizzaProject.Models.User", "user")
                        .WithMany("Orders")
                        .HasForeignKey("CustId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("PizzaProject.Models.OrderDetail", b =>
                {
                    b.HasOne("PizzaProject.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaProject.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("order");
                });

            modelBuilder.Entity("PizzaProject.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
