using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class PizzasDeliveryAddress : BaseEntity
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer{ get; set; }
    }
}
