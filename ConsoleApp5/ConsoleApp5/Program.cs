using System;

namespace ConsoleApp5
{
    class rectangle
    {
        internal double length;
        internal double breadth;
        int temp;
        private  double getarea()
        {
            return (length * breadth);
        }
        public void swap(ref int x,ref int y)
        {
            temp = x;
            x = y;
            y = temp;
        }
        public void assign(out int x)
        {
            x = 78;
        }
        internal void display()
        {
            Console.WriteLine("Length is {0}", length);
            Console.WriteLine("Breadth is {0}", breadth);
            Console.WriteLine("Area is {0}", getarea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=6;
            int ig;
            rectangle rect = new rectangle();
            rect.length = 3.5;
            rect.breadth = 4.5;
            rect.display();
            Console.WriteLine("Before swqp is  {0} ", a);
            Console.WriteLine("Before swap, b is {0}",  b);
            rect.swap(ref a, ref b);
            Console.WriteLine("After swap, a is {0}", a);
            Console.WriteLine("After swap, b is {0}", b);
            rect.assign(out ig);
            Console.WriteLine("ig is {0}", ig);


        }
    }
}
