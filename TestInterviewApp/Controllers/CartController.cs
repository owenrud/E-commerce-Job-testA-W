using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestInterviewApp.Data;
using TestInterviewApp.Models;

namespace TestInterviewApp.Controllers
{
    public class CartController : Controller
    {
        private readonly EcommerceDbContext _context;
        public CartController(EcommerceDbContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var carts = await _context.Carts.ToListAsync(); 
            return View(carts);
        }
        public IActionResult Checkout(string grandTotal)
        {
            var total = int.Parse(grandTotal);
            ViewBag.GrandTotal = total;
            return View();
        }
        public IActionResult Add(int id)
        {
            // Check if the product is already in the cart
            var existingCartItem = _context.Carts.FirstOrDefault(c => c.Id_product == id);
            if (existingCartItem != null)
            {
                // Optionally: show a message or just redirect
                TempData["Message"] = "Product already in cart!";
                return RedirectToAction("Index", "Products"); // or your product list page
            }

            // Find product by id
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            // Add product to cart
            var cartItem = new Cart
            {
                Id_product = product.Id,
                nama = product.nama,
                harga = product.harga,
                gambar = product.gambar
            };

            _context.Carts.Add(cartItem);
            _context.SaveChanges();

            TempData["Message"] = "Product added to cart!";
            return RedirectToAction("Index"); // or your cart page
        }

        public async Task <IActionResult> Delete(int id) { 
        var item = await _context.Carts.FirstOrDefaultAsync(x=> x.Cart_Id == id);
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        public async Task <IActionResult> ConfirmDelete(int id)
        {
            var item = await _context.Carts.FindAsync(id);
            if(item != null)
            {
                _context.Carts.Remove(item);
               await _context.SaveChangesAsync();

            }
            return RedirectToAction("Index");
        }
    }
    
    

}
