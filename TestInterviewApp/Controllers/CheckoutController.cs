using Microsoft.AspNetCore.Mvc;

namespace TestInterviewApp.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
