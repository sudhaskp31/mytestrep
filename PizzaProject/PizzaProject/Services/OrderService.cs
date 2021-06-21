using Microsoft.EntityFrameworkCore;
using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaProject.Services
{
    public class OrderService
    {
         PizzaContext context;
        
        //public Item item = new Item();
        //public Crust crust = new Crust();
        // public Topping topping = new Topping();
        // List<Item> items = new List<Item>();
        //  List<Crust> crusts = new List<Crust>();
        //  List<Topping> toppings = new List<Topping>();


        public OrderService()
        {
            context = new PizzaContext();
        }
        public void OrderDisplayScreen(string email)
        {
            bool flag = true;
            while (flag) { 

            Console.WriteLine("Please enter your choice");
            Console.WriteLine("1. Make new order");
            Console.WriteLine("2. Cancel Order");
            Console.WriteLine("3. View all  orders");
            Console.WriteLine("4. Quit");

            int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        TakeNewOrder(email);
                        break;
                    case 2:
                        Console.WriteLine("Please enter your orderid");
                        int orderid = Convert.ToInt32(Console.ReadLine());
                        CancelOrder(orderid);
                        break;
                    case 3:
                        ViewAllOrders(email);
                        break;
                    case 4:
                        flag = false;
                        break;
                }

            }
            void TakeNewOrder(string email)
            {
                DisplayPizzaDetails(email);
            }
            void DisplayPizzaDetails(string email)
            {
                Console.WriteLine("Here are the Pizza Details");
                foreach (var item in context.items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("***************************************************************************");
                foreach (var item in context.crusts)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("****************************************************************************");
                foreach (var item in context.toppings)
                {
                    Console.WriteLine(item);
                }
                try
                {
                    Console.WriteLine("*****************************************************************************");
                    Console.WriteLine("Please enter the name of the pizza");
                    string pname = Console.ReadLine();
                    Console.WriteLine("What type of crust do you choose?");
                    string cname = Console.ReadLine();
                    Console.WriteLine("What topping would you like to add?");
                    string tname = Console.ReadLine();
                    Console.WriteLine("Please enter how many pizza do you want");
                    int pizzacount = Convert.ToInt32(Console.ReadLine());
                    ShowPrice(pname, cname, tname, pizzacount, email);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops..something went wrong,please check the details");
                   // Console.WriteLine(e.Message);
                }
            }
            void ShowPrice(string pname, string cname, string tname, int pizzacount, string email)
            {
                Item it = context.items.Single(x => x.PizzaName == pname);
                Crust cr = context.crusts.Single(y => y.CrustName == cname);
                Topping tp = context.toppings.Single(z => z.ToppingName == tname);
                User us = context.users.Single(u => u.Email == email);
                float gst = 0.07F;
                string address = us.Address;
                float price = (it.Price + cr.Price + tp.Price) * pizzacount;
                float PriceWithGST = price + (price * gst);
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("YOUR ORDER DETAILS");
                Console.WriteLine("Name of Pizza:             "+pname);
                Console.WriteLine("Crust Type:                   "+cname);
                Console.WriteLine("Toppings chosen:          " +tname);
                Console.WriteLine("Total Amount payable:  " + PriceWithGST);
                Console.WriteLine("The pizza will be delivered to the following address");
                Console.WriteLine(address);
                Console.WriteLine("------------------------------------------------------------------------------------------");
                InsertIntoOrderAndDetails(email, PriceWithGST, pizzacount,pname,cname,tname);
            }
            void InsertIntoOrderAndDetails(string email, float price, int pizzacount,string pname,string cname,string tname)
            {
                Order order = new Order();
                OrderDetail orderdetail = new OrderDetail();
                order.TotalAmount = price;
                User user = context.users.Single(u => u.Email == email);
                Item item= context.items.Single(ip => ip.PizzaName== pname);
                
                order.CustId = user.UserId;
                order.Date = DateTime.Now;
                order.PizzaName = pname;
                order.CrustName = cname;
                order.ToppingName = tname;
                context.Add(order);
                context.SaveChanges();
                orderdetail.Quantity = pizzacount;
                orderdetail.OrderId = order.OrderId;
                orderdetail.ItemId = item.ItemId;
                context.orderdetails.Add(orderdetail);
                context.SaveChanges();


            }
             void CancelOrder(int orderid)
            {

                Order order = context.orders.Single(o => o.OrderId == orderid);
                context.orders.Remove(order);
                context.SaveChanges();
                Console.WriteLine("ORDER IS CANCELLED");


            }
             void ViewAllOrders(string emailid)
            {
                User user = context.users.Single(u => u.Email == emailid);
                var orderlist = context.orders.Where(co => user.UserId == co.CustId).ToList();
                if (orderlist.Count==0)
                    Console.WriteLine("You have no orders yet");
                Console.WriteLine("*******************************************************************");
               
                foreach (var item in orderlist)
                {
                    Console.WriteLine(item);

                    OrderDetail od = context.orderdetails.Single(d => d.OrderId == item.OrderId);
                    var pizzaname = context.items.Single(i => i.ItemId == od.ItemId);
                    Console.WriteLine("Pizza Name:            " + pizzaname.PizzaName);
                   // Console.WriteLine("Crust Type:          "+item.CrustName);
                   // Console.WriteLine("Toppings Name:   " +item.ToppingName);
                   
                    Console.WriteLine("Quantity:                " + od.Quantity);
                    Console.WriteLine("*************************************************************************");

                }
               

            }

        }
    }
}
