using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderNumber { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public DateTime TimeToCollect { get; set; }
        public float OverallPrice { get; set; }
        public float Tip { get; set; }
        public float TotalAmount { get; set; }
        public IEnumerable<OrderedCoffee> OrderedCoffees { get; set; }
    }
}
