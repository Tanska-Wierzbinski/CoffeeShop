using CoffeeShop.Application.DTOs.Addition;
using CoffeeShop.Application.DTOs.Coffee;
using CoffeeShop.Application.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace CoffeeShop.Application.DTOs.OrderedCoffee
{
    public class AddOrderedCoffeeDto
    {
        public CoffeeDto Coffe { get; set; }
        public SizeDto Size { get; set; }
        public IEnumerable<AdditionDto> Additions { get; set; }
        public List<SelectListItem> CoffeesSL { get; set; }
        public List<SelectListItem> SizesSL { get; set; }
        public List<SelectListItem> AdditionsSL { get; set; }
    }
}
