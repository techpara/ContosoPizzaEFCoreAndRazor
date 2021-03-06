using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class Pizzas : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PizzaCategoryID { get; set; }
        public PizzaCategories PizzaCategory { get; set; }
    }
}
