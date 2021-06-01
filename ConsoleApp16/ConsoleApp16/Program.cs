using System;

namespace ConsoleApp16
{
    interface Program
    {


         void check_repeated(string str);




    }
    class child : Program
    {
        int count = 0;
        int i, j;
        public void check_repeated(string str)
        {
            char[] chr1 = str.ToCharArray();
            for (i = 0; i < str.Length; i++)
            {
                for (j = i + 1; j < str.Length; j++)
                {
                    if (chr1[i] == chr1[j])
                    {
                        count = count + 1;
                        Console.WriteLine(chr1[j]);
                    }
                }
            }
            if (count > 1)
            {
                Console.WriteLine("Repeated");


            }
        }
        public void display()
        {
            Console.WriteLine("I am in abstract");

        }
        class main
        {
            static void Main(string[] args)
            {
                string str1 = "Great responsibility";
                child pr = new child();

                pr.check_repeated(str1);
                pr.display();

            }
        }

    }
}
