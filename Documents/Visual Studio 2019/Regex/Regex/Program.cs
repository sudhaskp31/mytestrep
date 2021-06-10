using System;
using System.Text.RegularExpressions;

namespace RegexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex=new Regex(@"^\+65(6|8|9)\d{7}$");
            var true_mob = "+6561234567";
            //var false_mob = "+6512345678";
            if (regex.IsMatch(true_mob))
                 {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not correct");
            }
        }
    }
}
