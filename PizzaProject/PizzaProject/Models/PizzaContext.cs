using Microsoft.EntityFrameworkCore;
using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    public class PizzaContext : DbContext
    {
        readonly string connectionString = @"Data source=LAPTOP-E9STVIGE\SQLEXPRESS;Integrated security = true;Initial catalog=dbPizzaOrder";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<User> users { get; set; }
        
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderdetails { get; set; }

        public DbSet<Topping> toppings { get; set; }
        public DbSet<Crust> crusts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(k => new { k.OrderId, k.ItemId });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
            PizzaName = "Cheese Pizza",
                IsVeg = "Yes",
                Price = 15,
                Remarks = "Classic Masterpiece"
            },
        new Item {
            ItemId=2,
            PizzaName = "Veggie Pizza",
            IsVeg = "Yes",
            Price = 13,
            Remarks = "Flavoured with Capsicum,Pepper and Onions"
        },
           new Item {
               ItemId=3,
               PizzaName = "Pepperoni Pizza",
               IsVeg = "No",
               Price = 16.50F,
               Remarks = "Crispy,salty,round Pepperoni"
           },
           new Item {
               ItemId=4,
               PizzaName = "Meat Pizza",
               IsVeg = "No",
               Price = 18.50F,
               Remarks = "Ground Meat with Sausage"
           },
           new Item {
               ItemId=5,
               PizzaName = "Margheritta Pizza",
               IsVeg = "No",
               Price = 18,
               Remarks = "Fresh Mozerilla,Basil and tomatoes"
           },
            new Item {
                ItemId=6,
                PizzaName = "BBQ Chicken Pizza",
                IsVeg = "No",
                Price = 16,
                Remarks = "Tangy,sweet"
            },
            new Item {
                ItemId=7,
                PizzaName = "Hawaiian Pizza",
                IsVeg = "No",
                Price = 20,
                Remarks = "Pineapple with ham,sweet n salty"
            }); ;

            modelBuilder.Entity<Crust>().HasData(new Crust
            {
                CrustId=1,
                CrustName = "Neapolitan",
                Price = 3

            },
            new Crust
            {
                CrustId=2,
                CrustName = "Chicago-Deep-Dish",
                Price = 5.50F
            },
            new Crust
            {
                CrustId=3,
                CrustName = "New-Haven-Style",
                Price = 4
            },
            new Crust
            {
                CrustId=4,
                CrustName = "Flatbread",
                Price = 3.50F
            });

            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                ToppingId=1,
                ToppingName = "Green Pepper",
                IsVeg = "Yes",
                Price = 3
            },
            new Topping
            {
                ToppingId=2,
                ToppingName = "Black Olives with Chicken pieces",
                IsVeg = "No",
                Price = 5.50F

            });



            }
        }
    }




    

