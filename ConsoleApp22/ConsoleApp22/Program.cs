using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace ConsoleApp22
{
   class Result
    {

        /*
         * Complete the 'getMax' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts STRING_ARRAY operations as parameter.
         */

       public static List<int> getMax(List<string> operations)
        {
            Stack<string> origstr = new Stack<string>();
            Stack<string> maxstr = new Stack<string>();
            List<int> a = new List<int>();
            for (int i = 0; i < operations.Count ; i++)
            {
                if (Convert.ToInt32(operations[i]) == 1)
                {

                    //Console.WriteLine("I am 1");
                    origstr.Push(operations[i+1]);
                    if (maxstr.Count() != 0)
                    {
                        if (Convert.ToInt32(operations[i + 1]) > Convert.ToInt32(maxstr.Peek()))
                        {
                            maxstr.Push(operations[i + 1]);
                            //Console.WriteLine(maxstr.Peek());
                        }
                        else
                        {
                            maxstr.Push(maxstr.Peek());
                        }
                    }

                    else
                    {
                       // Console.WriteLine("Maxstr is fresh");
                        maxstr.Push(operations[i + 1]);
                       // Console.WriteLine(maxstr.Peek());
                    }


                    
                }
                if (Convert.ToInt32(operations[i]) ==2 && maxstr.Count!=0)
                {
                   // Console.WriteLine("I am 2");
                    origstr.Pop();
                    maxstr.Pop();
                    //Console.WriteLine(maxstr.Peek());

                }
                if (Convert.ToInt32(operations[i]) ==3 && maxstr.Count()!=0)
                {
                    //Console.WriteLine("I am 3");
                    a.Add(Convert.ToInt32(maxstr.Peek()));
                    //Console.WriteLine(maxstr.Peek());
                    
                }


            }
            
           

            return (a);
        }

   }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> ops = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string opsItem = Console.ReadLine();
                ops.Add(opsItem);
            }
            
            List<int> res = Result.getMax(ops);
            foreach (int it in res)
            {
                Console.WriteLine(it);
            }
            

            // textWriter.WriteLine(String.Join("\n", res));

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
