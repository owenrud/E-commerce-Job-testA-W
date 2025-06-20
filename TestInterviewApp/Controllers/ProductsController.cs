using Microsoft.AspNetCore.Mvc;

namespace TestInterviewApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
