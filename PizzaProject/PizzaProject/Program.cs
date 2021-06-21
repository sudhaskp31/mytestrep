using PizzaProject.Models;
using PizzaProject.Services;
using System;

namespace PizzaProject
{
    public class Program
    {
         public UserLoginService userloginservice;
         public OrderService orderservice;
         public Program()
         {
             userloginservice = new UserLoginService();
             orderservice = new OrderService();

         }




        public static void Main(string[] args)
        {
            Program program = new Program();
             UserLoginService userloginservice = new UserLoginService();
             OrderService orderservice = new OrderService();
             Console.WriteLine("Are you a first time user? yes/no");
             string choice = Console.ReadLine().ToLower();
             if (choice == "yes")

                 userloginservice.CreateUser();

            userloginservice.LoginScreen();





             }
          
            
        }
    }


  


