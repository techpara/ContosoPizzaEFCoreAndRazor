using ContosoPizzaEFCoreAndRazor.Models;
using System.Linq;

namespace ContosoPizzaEFCoreAndRazor.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContosoPizzaDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.PizzaCategories.Any())
            {
                return;  
            }

            var categories = new PizzaCategories[]
            {
                new PizzaCategories{ Name = "Italian" , Details = "Authenticate Italian pizza"},
                new PizzaCategories{ Name = "Maxican" , Details = "Fusion pizza"}
            };

            context.PizzaCategories.AddRange(categories);
            context.SaveChanges();

            var pizzaa = new Pizzas[]
            {
                new Pizzas{Name = "Margarita", Price = 51, PriceCategoryId = 1},
                new Pizzas{Name = "Delecious Cheese", Price = 41, PriceCategoryId = 1},
                new Pizzas{Name = "Capcicum Onion Cheese", Price = 31, PriceCategoryId = 1},

            };

            context.Pizzas.AddRange(pizzaa);
            context.SaveChanges();
        }
    }
}

