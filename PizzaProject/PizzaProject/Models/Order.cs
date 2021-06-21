using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public string PizzaName { get; set; }
        public string CrustName { get; set; }
        public string ToppingName { get; set; }
        public DateTime Date { get; set; }
        public float TotalAmount { get; set; }

        [ForeignKey("CustId")]
        public User user { get; set; }

        public override string ToString()
        {
            return "OrderID:               " + OrderId +
                "\nPizza Name:             "+PizzaName+
                "\nCrust Type:               "+CrustName+
                "\nToppings Name:        "+ToppingName+
                "\nDate:                        " + Date +
                "\nTotalAmount              " + TotalAmount + "\n";
        }

    }

}
