using System;

namespace QuestionsEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employeepromotion ep = new Employeepromotion();
            //  ep.employeepromotion();
            //ep.findindex();

            // ep.sort();
            PrintEmployee addEmpPrint = new PrintEmployee();
            Console.WriteLine("ADD EMPLOYEES");
            addEmpPrint.AddEmployee();
            Console.WriteLine("FETCH EMPLOYEE DETAILS BY ID");
            addEmpPrint.GetEmployeeById();
            Console.WriteLine("SORTING BASED ON SALARIES");
            addEmpPrint.sort();
            Console.ReadKey();
        }
    }
}
