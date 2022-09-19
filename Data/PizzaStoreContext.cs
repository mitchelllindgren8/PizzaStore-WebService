using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext (DbContextOptions<PizzaStoreContext> options)
            : base(options)
        {
        }

        //public DbSet<PizzaStore.Models.Pizza> Pizzas { get; set; }
        public DbSet<PizzaStore.Models.Pizza> Pizzas { get; set; } = default!;
    }
}
