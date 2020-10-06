using CoffeeShop.Application.DTOs.OrderedCoffee;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.DTOs.Order
{
    public class DetailsOrderDto
    {
        public int Id { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public float OverallPrice { get; set; }
        public float Tip { get; set; }
        public IEnumerable<AddOrderedCoffeeDto> OrderedCoffees { get; set; }

    }
}
