using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestInterviewApp.Data;

namespace TestInterviewApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly EcommerceDbContext _context;
        public ProductsController(EcommerceDbContext context) 
        { 
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}
