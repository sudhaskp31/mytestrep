using System;

namespace ConsoleApp12
{
    abstract class Animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("ZZzzz...");
        }
    }
    class Pig:Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Pig shouts yee yee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig pi=new Pig();
            pi.animalsound();
            pi.sleep();
        }
    }
}
