using CoffeeShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Infrastructure.Context
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options) : base(options)
        {

        }

        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Addition> Additions { get; set; }
        public DbSet<OrderedCoffee> OrderedCoffees { get; set; }
        public DbSet<OrderedCoffeeAddition> OrderedCoffeeAdditions { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedCoffeeAddition>().HasKey(t => new { t.OrderedCoffeId, t.AdditionId });

            modelBuilder.Entity<OrderedCoffeeAddition>()
                .HasOne(m => m.OrderedCoffee)
                .WithMany(ma => ma.Additions)
                .HasForeignKey(m => m.OrderedCoffeId);
        }
    }
}
