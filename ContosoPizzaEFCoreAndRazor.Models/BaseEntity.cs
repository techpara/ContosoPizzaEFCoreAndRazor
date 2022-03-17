using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEFCoreAndRazor.Models
{
    public class BaseEntity
    {
        public int? CreatedBy { get; set; }
        public DateTimeOffset CreatedOnUTCDate { get; set; } = DateTimeOffset.UtcNow;
        public int? ModifiedBy { get; set; }
        public DateTimeOffset? UpdatedOnUTCDate { get; set; }
    }
}
