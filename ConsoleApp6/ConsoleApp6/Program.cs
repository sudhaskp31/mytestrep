using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /**int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();**/
            int? num1 = null;
            int? num2 = 5;
            int num3;
            num3 = num1 ?? 3;
            Console.WriteLine(num3);
            num3 = num2 ?? 3;
            Console.WriteLine(num3);
        }
    }
}
