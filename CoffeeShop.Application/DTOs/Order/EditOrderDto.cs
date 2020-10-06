using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.DTOs.Order
{
    public class EditOrderDto : AddOrderDto
    {
        public int Id { get; set; }
    }
}
