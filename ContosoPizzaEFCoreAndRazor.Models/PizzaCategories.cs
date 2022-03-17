using System.ComponentModel.DataAnnotations;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class PizzaCategories : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
