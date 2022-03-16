using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPizzaEFCoreAndRazor.Data;
using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoPizzaEFCoreAndRazor.Models.DTO;

namespace ContosoPizzaEFCoreAndRazor.UI.Pages.pizza
{
   
    public class createModel : PageModel
    {
        private readonly ContosoPizzaDBContext _dbContext;
        public createModel(ContosoPizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public PizzaDTO pizzaModel { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public IActionResult OnGet()
        {
            Categories = _dbContext.PizzaCategories.Select(a =>
                                    new SelectListItem
                                    {
                                        Value = a.ID.ToString(),
                                        Text = a.Name
                                    }).ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var entry = _dbContext.Add(new Pizzas());
            entry.CurrentValues.SetValues(pizzaModel);
            await _dbContext.SaveChangesAsync();
            return Redirect("home");
        }
    }
}
