using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsEmployee
{
    public class Employeepromotion
    {
        List<string> employees = new List<string>();
        public void employeepromotion()
        {
            Console.WriteLine("Please enter the promotion list");

            string promoname = "no";

            do
            {
                // Employee emp = new Employee();
                promoname = Console.ReadLine();
                employees.Add(promoname);
                //Console.WriteLine("Do you like to continue?? If not then enter no");
                // string str = Console.ReadLine().ToLower();
            } while (promoname.ToLower() != "no");
            Console.WriteLine("EMPLOYEES LIST INTHE ORDER OF PROMOTION");
            for (int i = 0; i < employees.Count - 1; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        public void findindex()
        {
            Console.WriteLine("Please enter the employee name do you want to find the position");
            string ename = Console.ReadLine();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] == ename)
                {
                    Console.WriteLine($"The employee is at {i+1} position ");
                }
            }
        }
        public void sort()
        {
            employees.Sort();
            Console.WriteLine("EMPLOYEES IN ASCENDING ORDER");
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        

    }
}

