using System;

namespace ConsoleApp4
{
    class area
    {
        const double pi = 3.14;
        internal double findarea(double rad)
        {
            return (pi * rad * rad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            area a = new area();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello\tWorld\n");
            int i = 5;
            int i1 = 6;
            if (i == 5 && i1 == 6)
                Console.WriteLine("i and i1 are equal");


            /**double r;
           
            double area;
            Console.WriteLine("Enter the radius\n");
            r = Convert.ToDouble(Console.ReadLine());
            area = a.findarea(r);
            Console.WriteLine("The area is \n");
            Console.WriteLine(area);**/


        }
    }
}
