using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Models
{
    public class OrderedCoffee
    {
        public int Id { get; set; }

        public int CoffeeId { get; set; }
        public Coffee Coffee { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }

        public IEnumerable<OrderedCoffeeAddition> Additions { get; set; }
        public float Price { get; set; }


        public int OrderId { get; set; }
    }
}
