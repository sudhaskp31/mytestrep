using System;
using System.Collections.Generic;
using System.Text;

namespace Understandingrelations
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        private string passcode { get; set; }
        public int check;
       public  string phone;
        public int Check
        {
            get
            {
                return (check);
            }
            set
            {
                check = value*2;
            }
        }
        /*public int Age
        {
            get
            {
                return (age);
            }
            set
            {
                age = value;
            }
        }*/
        public string Phone
        {
            get
            {
               
                return phone;
            }
            set
            {
                phone = value.Substring(0,5)+"****";
            }
        }
        public void printcheck()
        {
            Console.WriteLine("Check is " + check);
        }
        public void printphone()
        {
            Console.WriteLine("Phone is " + phone);
        }
       public void printage()
        {
            Console.WriteLine("Age is " + Age);
        }
        public void printname()
        {
            Console.WriteLine("Name is " + Name);
        }

    }
}
