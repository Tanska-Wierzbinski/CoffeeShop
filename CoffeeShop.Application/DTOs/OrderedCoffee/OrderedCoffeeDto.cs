using CoffeeShop.Application.DTOs.Addition;
using CoffeeShop.Application.DTOs.Coffee;
using CoffeeShop.Application.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.DTOs.OrderedCoffee
{
    public class OrderedCoffeeDto
    {
        public int Id { get; set; }
        public CoffeeDto Coffe { get; set; }
        public SizeDto Size { get; set; }
        public IEnumerable<AdditionDto> Additions { get; set; }
    }
}
