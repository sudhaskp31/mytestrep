using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Employee //:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee()
        {

        }
        public Employee(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
       public override bool Equals(object obj)
        {
            //float f1=10.2f;
            //int num1=(int)f1;
            Employee emp1 = this;
            Employee emp2 = (Employee)obj;
            if (emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Age == emp2.Age)
                return true;
            return false;
        }
        public override string ToString()
        {
            return "Id " + Id + "\nName " +Name+ "\nAge " + Age;
                
        }

       /* int IComparable<Employee>.CompareTo(Employee other)
        {
            //if (this.Id > other.Id)
            //return -1;
            //else if (this.Id < other.Id)
            //return 1;
            //else
            //return 0;
            return this.Name.CompareTo(other.Name);
        }*/
    }
}
