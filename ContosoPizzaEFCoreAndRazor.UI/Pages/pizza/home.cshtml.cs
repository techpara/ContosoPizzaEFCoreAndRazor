using ContosoPizzaEFCoreAndRazor.Data;
using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaEFCoreAndRazor.UI.Pages
{
    public class HomeModel : PageModel
    {

        private readonly ContosoPizzaDBContext _dbContext;
        public HomeModel(ContosoPizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Pizzas> allPizza = new List<Pizzas>();

        public async Task<IActionResult> OnGetAsync()
        {
            allPizza = await _dbContext.Pizzas.Include(x=>x.PizzaCategory).ToListAsync();
            return Page();
        }
    }
}