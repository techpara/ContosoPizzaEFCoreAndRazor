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
                new Pizzas{Name = "Margarita", Price = 51, PizzaCategoryID = 1},
                new Pizzas{Name = "Delecious Cheese", Price = 41, PizzaCategoryID = 1},
                new Pizzas{Name = "Capcicum Onion Cheese", Price = 31, PizzaCategoryID = 1},

            };

            context.Pizzas.AddRange(pizzaa);
            context.SaveChanges();


            var customers = new Customers[]
            {
                new Customers{Name = "Customer 1"},
                new Customers{Name = "Customer 2"},
                 new Customers{Name = "Customer 3"},
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();


            var addresses = new PizzasDeliveryAddress[]
           {
                new PizzasDeliveryAddress{ Street="A1", City = "NY", State = "NY", ZipCode="123456", CustomerId = 1},
                new PizzasDeliveryAddress{ Street="A1", City = "Mumbai", State = "MH", ZipCode="89897", CustomerId = 1},
           };

            context.PizzasDeliveryAddress.AddRange(addresses);
            context.SaveChanges();
        }
    }
}

