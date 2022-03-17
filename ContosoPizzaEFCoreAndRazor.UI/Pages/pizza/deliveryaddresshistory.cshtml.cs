using ContosoPizzaEFCoreAndRazor.Data;
using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaEFCoreAndRazor.UI.Pages
{
    public class deliveryaddresshistoryModel : PageModel
    {

        private readonly ContosoPizzaDBContext _dbContext;
        public deliveryaddresshistoryModel(ContosoPizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PizzasDeliveryAddress> pizzasDeliveryAddress = new List<PizzasDeliveryAddress>();

        public async Task<IActionResult> OnGetAsync()
        {
            var address = await _dbContext.PizzasDeliveryAddress.Where(x => x.ID == 1).FirstOrDefaultAsync();
            address.Street = address.Street + " " + DateTime.Now.Second.ToString();
            address.City = address.City + " " + DateTime.Now.Second.ToString();
            address.State = address.State + " " + DateTime.Now.Second.ToString();
            address.ZipCode = address.ZipCode + " " + DateTime.Now.Second.ToString();
            await _dbContext.SaveChangesAsync();

            pizzasDeliveryAddress = await _dbContext
                .PizzasDeliveryAddress
                .TemporalAll()
                .Where(e => e.ID == 1)
                .OrderBy(e => EF.Property<DateTime>(e, "PeriodStart"))
                .ToListAsync();

            return Page();
        }
    }
}