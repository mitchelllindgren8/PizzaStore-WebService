using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    [Table("Toppings")]

    public class Topping
    {
        [Key]
        public int Id { get; set; }
        public string toppingName { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
    }

    [Table("Pizzas")]

    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Topping")]
        public int PizzaId { get; set;}
        public string toppingsList { get; set;}
        public Topping Topping { get; set; }
    }
}
