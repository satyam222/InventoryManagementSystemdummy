using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly MyAppDbContext _context;
        public DetailsModel(MyAppDbContext context)
        {
            _context = context;
        }
        public Product Products { get; set; }
        public async Task<IActionResult> OnGetAsync(int ? itemid)
        {
            if (itemid == null)
            {
                return NotFound();  
            }
            var product= await _context.Products.FirstOrDefaultAsync(p => p.ProductId == itemid);
            if (product == null)
            {
                return NotFound();
            }
            Products = product;
            return Page();

        }
    }
}
