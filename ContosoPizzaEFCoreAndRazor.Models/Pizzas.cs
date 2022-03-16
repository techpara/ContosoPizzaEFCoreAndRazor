using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class Pizzas
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PriceCategoryId { get; set; }
        public PizzaCategories PizzaCategory { get; set; }
    }
}
