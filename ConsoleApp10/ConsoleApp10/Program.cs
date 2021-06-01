using System;

namespace ConsoleApp10
{
    class Shape
    {
        protected double length;
        protected double breadth;
        internal void setlength(double l)
        {
            length = l;
        }
        internal void setbreadth(double b)
        {
            breadth = b;
        }
    }
     interface paintcost
    {
         public double getcost(double area);
    }
    class Rectangle : Shape, paintcost
    {
         internal  double getarea()
        {
            return (length * breadth);
        }
         public double getcost(double area)
        {
            return (area * 70);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.setlength(3);
            rect.setbreadth(2);
            double ar = rect.getarea();
            double cost = rect.getcost(ar);
            Console.WriteLine("The area is {0}", ar);
            Console.WriteLine("The cost is {0}", cost);

        }
    }
}
