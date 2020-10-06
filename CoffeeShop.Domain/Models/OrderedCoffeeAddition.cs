using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Models
{
    public class OrderedCoffeeAddition
    {
        public int OrderedCoffeId { get; set; }
        public OrderedCoffee OrderedCoffee { get; set; }

        public int AdditionId { get; set; }
        public Addition Addition { get; set; }
    }
}
