using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaEFCoreAndRazor.Data
{
    public class ContosoPizzaDBContext : DbContext
    {
        public ContosoPizzaDBContext(DbContextOptions<ContosoPizzaDBContext> options)
            : base(options)
        {
        }

        public DbSet<Pizzas> Pizzas { get; set; }
        public DbSet<PizzaCategories> PizzaCategories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<PizzasDeliveryAddress> PizzasDeliveryAddress { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzas>().ToTable("Pizzas");
            modelBuilder.Entity<PizzaCategories>().ToTable("PizzaCategories");
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<PizzasDeliveryAddress>().ToTable("PizzasDeliveryAddress", x => x.IsTemporal());
        }
    }
}
