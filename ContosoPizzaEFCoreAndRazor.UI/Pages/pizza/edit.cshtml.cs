using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPizzaEFCoreAndRazor.Data;
using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoPizzaEFCoreAndRazor.Models.DTO;

namespace ContosoPizzaEFCoreAndRazor.UI.Pages.pizza
{

    public class editModel : PageModel
    {
        private readonly ContosoPizzaDBContext _dbContext;
        public editModel(ContosoPizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public PizzaDTO pizzaModel { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Categories = _dbContext.PizzaCategories.Select(a =>
                                    new SelectListItem
                                    {
                                        Value = a.ID.ToString(),
                                        Text = a.Name
                                    }).ToList();

            pizzaModel = await _dbContext.Pizzas
                .Where(_ => _.ID == id)
                .Select(_ =>
                new PizzaDTO
                {
                    ID = _.ID,
                    Name = _.Name,
                    Price = _.Price,
                    PizzaCategoryID = _.PizzaCategoryID
                }).FirstOrDefaultAsync();

            if (pizzaModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var existingPizza = await _dbContext.Pizzas.FindAsync(id);

            if (existingPizza == null)
            {
                return NotFound();
            }

            //TO-DO Can use automapper
            existingPizza.Name = pizzaModel.Name;
            existingPizza.Price = pizzaModel.Price;
            existingPizza.PizzaCategoryID = pizzaModel.PizzaCategoryID;

            await _dbContext.SaveChangesAsync();
            return Redirect("home");
        }
    }
}
