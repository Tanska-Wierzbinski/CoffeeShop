using CoffeeShop.Application.DTOs.OrderedCoffee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace CoffeeShop.Application.DTOs.Order
{
    public class AddOrderDto
    {
        public DateTime TimeOfOrder { get; set; }
        public IEnumerable<AddOrderedCoffeeDto> OrderedCoffees { get; set; }
        public int[] NumberOfOrderedCoffees { get; set; }
        

        public AddOrderDto()
        {
            TimeOfOrder = DateTime.Now;
        }
    }
}
