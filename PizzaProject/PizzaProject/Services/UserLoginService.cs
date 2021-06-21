using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Services
{


    public class UserLoginService
    {
        readonly PizzaContext context;
        OrderService orderservice = new OrderService();
        public UserLoginService()
        {
            context = new PizzaContext();
        }
        public User RegisterUserDetails()
        {
            try
            {
                User user = new User();


                Console.WriteLine("Please enter Email address");
                user.Email = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                user.Password = Console.ReadLine();
                Console.WriteLine("Please enter your name");
                user.CustName = Console.ReadLine();
                Console.WriteLine("Please enter phone number");
                user.Phone = Console.ReadLine();
                Console.WriteLine("Please enter your address");
                user.Address = Console.ReadLine();
                return user;
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong entry");
               // Console.WriteLine(e.Message);
                return null;
            }

        }






        public void CreateUser()
        {
            User user = RegisterUserDetails();
            AddUser(user);

        }


        public void AddUser(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
            Console.WriteLine("Your registration is complete!");
            Console.WriteLine("Please login to continue");

        }
        public void LoginScreen()
        {
            try
            {
                Console.WriteLine("Please enter your email id");
                string email = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();
                CheckUser(email, password);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. Please check the values entered");
                // Console.WriteLine(e.Message);
            }

        }
        public void CheckUser(string email,string password)
        {
            
                
                if (UserLogin(email, password))
                {
                    Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN. YOU WILL BE TAKEN TO OUR ORDER SERVICE SCREEN");
                    orderservice.OrderDisplayScreen(email);
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                LoginScreen();
                }
            }
          

        
        public bool UserLogin(string email, string password)
        {
            try
            {
                User myuser = context.users.Single(u => u.Email == email
                  && u.Password == password);
                
                if (myuser != null)
               
                    return true; 
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument is null");
               // Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
                return false;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Sorry,could not find the user");//user understands
               // Console.WriteLine(e.Message);
               // Console.WriteLine(e.StackTrace);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops..something went wrong");
            }
            return false;

        }

    }
}

