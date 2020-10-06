using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.DTOs.Order
{
    public class SummaryOrderDto
    {
        public int Id { get; set; }
        public float TotalAmount { get; set; }
        public string OrderNumber { get; set; }
        public DateTime TimeToCollect { get; set; }
    }
}
