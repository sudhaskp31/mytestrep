using System;
using System.Collections.Generic;
using System.Text;

namespace Understandingrelations
{
    class Animal
    {
        public String Name { get; set; }
        public Animal()
        {
            Name = "Nothing yet";
        }
        public void eat()
        {
            Console.WriteLine("Eats grass");
        }
        public void sleep()
        {
            Console.WriteLine("zzzzzzz");
        }
        public virtual void move()
        {
            Console.WriteLine("Moves");
            Console.WriteLine(Name);
        }
        public override string ToString()
        {
            return "It is an animal.Yet to be named";
        }

    }
}
