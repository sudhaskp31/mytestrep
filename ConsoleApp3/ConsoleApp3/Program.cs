using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,inte;
            double d=123.34;
            string result;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Size of integer is {0}:", sizeof(int));
            i = (int)d;
            inte = Convert.ToInt32(d);
            if (i == inte)
                Console.WriteLine("i and inte are equal");
            else 
                Console.WriteLine("i and inte are not equal");
            result=(i==inte) ? "i and ie are equal": "i and ie are not equal";
            Console.WriteLine(result);

            Console.WriteLine("Integer value of d is {0}", i);
            Console.WriteLine("Integer converted value of d is {0}", inte);

            Console.ReadKey();
        }
    }
}
