using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public int ItemId {get;set;}
        

        public int Quantity { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public override string ToString()
        {
            return "Quantity: " + Quantity + "\n";
        }

    }
}
