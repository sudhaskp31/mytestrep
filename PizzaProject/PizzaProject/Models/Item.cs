using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
   public  class Item
    {
        
        public int ItemId { get; set; }
        public string PizzaName { get; set; }
        public string  IsVeg { get; set; }
        public float Price { get; set; }
        public string Remarks { get; set; }
        List<Order> Orders { get; set; }
        public override string ToString()
        {
            return "PizzaName: " + PizzaName +
                "  IsVeg: " + IsVeg +
                "  Price: " +"S$"+ Price +
                "  Remarks: " + Remarks + "\n";

        }
    }
}
