using System;

namespace ConsoleApp11
{
    
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("Printing integer {0}", i);
        }
        void print(string st)
        {
            Console.WriteLine("Printing string:{0}", st);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.print(3);
            p.print("Hello");
        }
    }
}
