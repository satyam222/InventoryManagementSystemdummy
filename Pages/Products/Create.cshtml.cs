using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InventoryManagementSystem.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly MyAppDbContext _context;
        public CreateModel(MyAppDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();//display the form
        }

        [BindProperty]
        public Product Products { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid ||_context.Products==null || Products == null)
            {
                return Page();
            }
            
            
           _context.Products.Add(Products);
            await _context.SaveChangesAsync();
            return  RedirectToPage(nameof(Index));

            
        }

    }
}
