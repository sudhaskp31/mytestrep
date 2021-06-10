using System;
using System.Collections.Generic;
using System.Text;

namespace Understandingrelations
{
    class Company
    {
        public string Name { get; set; }
        public string Description { get; set; }
        Person Employee { get; set; }
        public Company()
        {
            Employee = new Person();
            Employee.Name = "John";
            Employee.Age = 25;
            Employee.Check = 2;
            Employee.Phone = "91054329";
            Employee.printcheck();
            Employee.printphone();
            Employee.printname();
            Employee.printage();


        }
    }
}
