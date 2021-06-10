using LearningEFProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEFProject.Services
{
    public class ManageEmployees
    {
        SampleContext context;
        public ManageEmployees()
        {
            context = new SampleContext();
        }
        public bool AddEmployee(Employee employee)
        {
            //adds it to the localdbset
            context.Employees.Add(employee);
            //makes the insert in the database
            context.SaveChanges();
            return true;
        }
        public Employee GetEmployee(int id)
        {
            Employee employee =context.Employees.Where(emp => emp.Id == id).FirstOrDefault();
            return employee;
        }
        public bool EditEmployee(int id, Employee employee)
        {
            Employee myEmployee = GetEmployee(id);
            if (employee != null)
            {
                myEmployee.Name = employee.Name;
                myEmployee.Date_Of_Birth = employee.Date_Of_Birth;
                //context.Employees.Update(myEmployee);
                context.SaveChanges();
                return true;
                    
            }
            return false;
        }
        internal bool RemoveEmployee(int id)
        {
            Employee myEmployee = GetEmployee(id);
            context.Employees.Remove(myEmployee);
            context.SaveChanges();
            return true;
        }
        public List<Employee> GetAllemployees()
        {
            //connect to database fetch all the employeesrecord,puts it into a ist
            return context.Employees.ToList();
        }
    }
}
