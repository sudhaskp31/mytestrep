using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    public class Crust
    {
       
        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return "Crust Name: "+CrustName+
                "  Price "+"S$"+Price+"\n";
        }
    }
}
