using CoffeeShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    interface IOrderedCoffeeRepository : IRepository<OrderedCoffee>
    {
    }
}
