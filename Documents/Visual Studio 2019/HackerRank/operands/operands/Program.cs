using System;

namespace operands
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 12;
            int tip_percent = 20;
            int tax_percent = 8;
            double tip_cost = meal_cost * tip_percent / 100;
            Console.WriteLine(tip_cost);
            double tax_cost = meal_cost *tax_percent / 100;
            Console.WriteLine(tax_cost);
            double d_total_cost = (meal_cost + tip_cost + tax_cost);
            Console.WriteLine(d_total_cost);
            int total_cost = Convert.ToInt32(d_total_cost);
            Console.WriteLine(total_cost);
        }
    }
}
