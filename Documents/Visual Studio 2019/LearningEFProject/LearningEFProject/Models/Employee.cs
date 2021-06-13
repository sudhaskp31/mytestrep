using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEFProject.Models
{
    public class Employee
    {
        //Id tlls ORM that ORM it is primary key
        // if it is an integer, it will be an identity automatically
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }

    }
}
