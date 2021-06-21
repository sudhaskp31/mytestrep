using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    public class Topping
    {
        
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public string IsVeg { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return "Topping Name: "+ToppingName+
                "  IsVeg: "+IsVeg+
                "  Price: "+"S$"+Price+"\n";
        }
    }
}
