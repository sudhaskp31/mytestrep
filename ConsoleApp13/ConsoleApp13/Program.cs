using System;
interface Animal
{
    public void animalsound();
}
class canimal : Animal
{
    public  void animalsound()
    {
        Console.WriteLine("pig shouts");
    }
}

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            canimal ani = new canimal();
            ani.animalsound();

        }
    }
}
