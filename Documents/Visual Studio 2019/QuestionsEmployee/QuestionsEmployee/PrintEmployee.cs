using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsEmployee
{
    class PrintEmployee
    {
        Dictionary <int,Employee> employees = new Dictionary<int,Employee >();
        string choice="no";
        /// <summary>
        /// add employee details and store in a dictionary
        /// </summary>

        public void AddEmployee()
        {
            do
            {
                Employee emp = new Employee();
                emp.TakeEmployeeDetailsFromUser();
                employees.Add(emp.Id, emp);
                Console.WriteLine("Do you want to continue yes/no");
                choice = Console.ReadLine().ToLower();
            } while( choice!= "no");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }



        }

        

        public void GetEmployeeById()
        {
            Console.WriteLine("Please provide the employee id ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in employees.Values)
                {
                if (id==item.Id)
                {
                    Console.WriteLine(item);
                }
            }
        }
        /// <summary>
        /// sorting dictionary based on salary(conv dict to list)
        /// </summary>
        public void sort()
        {
            List<Employee> emplist= new List<Employee>();
            emplist = employees.Values.ToList();//converting dictionary values to list
            emplist.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));
          // emplist.Sort();
            foreach(var item in emplist)
            {
                Console.WriteLine(item);
            }

            
           

        }
        



    }
}
