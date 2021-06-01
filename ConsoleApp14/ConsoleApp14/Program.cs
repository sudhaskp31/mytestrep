using System;
using System.IO;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string writetext="Helloworld";
            File.WriteAllText("C#File", writetext);
            string readtext = File.ReadAllText("C#File");
            Console.WriteLine(readtext);

        }
    }
}
