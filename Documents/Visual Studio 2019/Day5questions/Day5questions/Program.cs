using System;
using System.Collections.Generic;

namespace Day5questions
{
    class Program
    {
        List<int> numbers = new List<int>();
        HashSet<int> hash = new HashSet<int>();
        //int[] numbers = new int[11];
        int i, j;



        public void find_prime()
        {

            Console.WriteLine("Enter a minimum number for prime");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum number for prime");
            int max = Convert.ToInt32(Console.ReadLine());
            List<int> primelist = new List<int>();
            for (int i = min; i <= max; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if ((i % j) == 0)
                    {
                        count = count + 1;

                    }

                }
                if (count == 0)
                {
                    primelist.Add(i);
                }
            }
            foreach (var item in primelist)
            {
                Console.WriteLine(item);
            }

        }
        List<int> getnumbersfromuser()
        {
            Console.WriteLine("Please enter 11 numbers");
            for (i = 0; i < 11; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            


            return numbers;


        }
        void DuplicateElementsInArray(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("First outer loop "+numbers[i]);
                int counts = 0;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counts = counts + 1;
                        //numbers.RemoveAll(num => num == numbers[i]);
                        break;
                    }
                }
                if (counts==0)
                {
                    Console.WriteLine("This is not repeated "+numbers[i]);
                }
            }
            
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                Program program = new Program();
                //program.find_prime();
                List<int> numarray = program.getnumbersfromuser();
              program.DuplicateElementsInArray(numarray);
                Console.ReadKey();
            }
        }
    }

