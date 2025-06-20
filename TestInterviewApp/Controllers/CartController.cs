using Microsoft.AspNetCore.Mvc;

namespace TestInterviewApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Checkout()
        {
            return View();
        }
    }
    

}
