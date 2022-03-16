using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPizzaEFCoreAndRazor.Data;
using ContosoPizzaEFCoreAndRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoPizzaEFCoreAndRazor.Models.DTO;
namespace ContosoPizzaEFCoreAndRazor.UI.Pages.pizza
{
    public class deleteModel : PageModel
    {
        private readonly ContosoPizzaDBContext _dbContext;
        public deleteModel(ContosoPizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string ErrorMessage { get; set; }
        public PizzaDTO? pizzaModel { get; set; }
        public async Task<IActionResult> OnGetAsync(int id, bool? saveChangesError)
        {
            pizzaModel = await _dbContext.Pizzas
                    .Where(_ => _.ID == id)
                    .Select(_ =>
                    new PizzaDTO
                    {
                        ID = _.ID,
                        Name = _.Name,
                        Price = _.Price
                    }).FirstOrDefaultAsync();

            if (pizzaModel == null)
            {
                return NotFound();
            }
            if (saveChangesError ?? false)
            {
                ErrorMessage = $"Error to delete the record id - {id}";
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var recordToDelete = await _dbContext.Pizzas.FindAsync(id);

            if (recordToDelete == null)
            {
                return Page();
            }

            try
            {
                _dbContext.Pizzas.Remove(recordToDelete);
                await _dbContext.SaveChangesAsync();
                return Redirect("/pizza/home");
            }
            catch
            {
                return Redirect($"./delete?id={id}&saveChangesError=true");
            }
        }
    }
}
