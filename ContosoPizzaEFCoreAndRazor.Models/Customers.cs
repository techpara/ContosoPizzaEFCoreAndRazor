using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class Customers : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PizzasDeliveryAddressId { get; set; }
        public ICollection<PizzasDeliveryAddress>? PizzasDeliveryAddress{ get; set; }
    }
}
