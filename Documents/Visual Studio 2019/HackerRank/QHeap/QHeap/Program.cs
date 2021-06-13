using System;
using System.IO;
using System.Collections.Generic;

namespace QHeap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int min;
            void printmin(List<int> a)
            {
               
                a.Sort();
                Console.WriteLine(a[0]);
                
            }
            //int n = Convert.ToInt32(Console.ReadLine());
            List<int> s = new List<int>();
            for (int i = 0; i < n; i++)
            
                string[] query = Console.ReadLine().Split();
                if ((query.Length > 1) && (Convert.ToInt32(query[0])==1))
                {
                    //Push
                    int value = Convert.ToInt32(query[1]);
                    s.Add(value);
                }
                if ((query.Length>1) && (Convert.ToInt32(query[0])==2))
                {
                    int value = Convert.ToInt32(query[1]);
                    s.Remove(value);
                }
                
                else
                {
                    printmin(s);

                }
            }
        }
    }
}
