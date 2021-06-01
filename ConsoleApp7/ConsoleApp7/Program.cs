using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /**int[] n = new int[4] ;
            for (int i = 0; i < 3; i++)
                n[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                Console.WriteLine(n[i]);**/
            string[] s1=  { "Sudha", "Senthil" };
            //string s2=string.Join("Padmaja", s1);
            string s2 = "Sudha" + "Senthil";
            string s3 = string.Join("", s1);
            Console.WriteLine(s2+s1);
            string str1 = "ss";
            string str2 = "ss";
            if (string.Compare(str1, str2) == 0)
                Console.WriteLine("both strings are equal");

        }
    }
}
