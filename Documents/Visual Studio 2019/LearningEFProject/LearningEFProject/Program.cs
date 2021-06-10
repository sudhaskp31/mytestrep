using LearningEFProject.Models;
using LearningEFProject.Services;
using System;
using System.Collections.Generic;

namespace LearningEFProject
{
    class Program
    {
        private ManageEmployees manageEmployees;
        private object em;
        private manageSkills manageSkillsobj;

        public Program()
        {
            manageEmployees = new ManageEmployees();
            manageSkillsobj = new manageSkills();
        }
        Employee TakeEmployeeDetails()
        {
            Employee employee = new Employee();
            Console.WriteLine("pls enter the employee name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Pls enter employee date pf birth");
            employee.Date_Of_Birth=Convert.ToDateTime(Console.ReadLine());
            return employee;
        }
        SkillsTable TakeSkillsDetails()
        {
            SkillsTable myskT = new SkillsTable();
            Console.WriteLine("Please enter skillname");
            myskT.SkillName = Console.ReadLine();
            Console.WriteLine("Please enter skill description");
            myskT.SkillDescription = Console.ReadLine();
            return myskT;
        }
        void CreateEmployee()
        {
            Employee employee = TakeEmployeeDetails();
            manageEmployees.AddEmployee(employee);
        }
        void CreateSkills()
        {
            SkillsTable skt = TakeSkillsDetails();
            manageSkillsobj.AddSkills(skt);
        }

        void UpdateEmployee()
        {
            Console.WriteLine("Please enter the employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employee = TakeEmployeeDetails();
            if (manageEmployees.EditEmployee(id,employee))
                Console.WriteLine("Details updated");
            else
                Console.WriteLine("Hm...Not updated");
        }
        void UpdateSkills()
        {
            Console.WriteLine("Please enter skill name");
            string skname = Console.ReadLine();
            SkillsTable skillsTable = TakeSkillsDetails();
            if (manageSkillsobj.EditSkills(skname,skillsTable))
            {
                Console.WriteLine("Details Updated");
            }
            else
                Console.WriteLine("Hmmm...Not Updated");

        }
        void DeleteEmployee()
        {
            Console.WriteLine("please enter the employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            if(manageEmployees.RemoveEmployee(id))
                Console.WriteLine("Employee deleed");
            else
                Console.WriteLine("Hmmm..not deleted");
        }
        void DeleteSkills()
        {
            Console.WriteLine("Please enter skill name");
            string sname = Console.ReadLine();
            if (manageSkillsobj.DeleteSkills(sname))
                Console.WriteLine("Skill Deleted");
            else
                Console.WriteLine("Hmmm... not deleted");
        }
        void PrintEmployees()
        {
            List<Employee> employees = manageEmployees.GetAllemployees();
            foreach(var item in employees)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Date_Of_Birth);
                Console.WriteLine("----------");
            }
        }
        void PrintSkills()
        {
            List<SkillsTable> skList = manageSkillsobj.GetAllSkills();
            foreach(var item in skList)
            {
                Console.WriteLine(item.SkillName);
                Console.WriteLine(item.SkillDescription);
                Console.WriteLine("---------------------");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* SampleContext sampleContext = new SampleContext();
             Employee emp = new Employee()
             {
                 Id = 1,
                 Name = "aB",
                 Date_of_Birth = new DateTime(1990, 12, 10)
             };
             sampleContext.Employees.Add(emp);*/
            Program program = new Program();
            //program.CreateEmployee();
            //program.PrintEmployees();
            // program.UpdateEmployee();
            program.CreateSkills();
            program.PrintSkills();
            Console.ReadKey();

        }
    }
}
