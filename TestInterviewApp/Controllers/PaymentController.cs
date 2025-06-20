using Microsoft.AspNetCore.Mvc;
using TestInterviewApp.api;
using TestInterviewApp.Models;

namespace TestInterviewApp.Controllers
{
    [ApiController]
    [Route("api/payment/token")]
    public class PaymentController : ControllerBase
    {
        private readonly MidtransService _svc;
        public PaymentController(MidtransService svc) => _svc = svc;

        [HttpPost("snap")]
        public async Task<IActionResult> CreateSnap([FromBody] SnapRequest req)
        {
            var payload = new
            {
                transaction_details = new { order_id = req.OrderId, gross_amount = req.Amount },
                customer_details = req.Customer
            };
            var resp = await _svc.CreateSnapTransaction(payload);
            return Content(resp, "application/json");
        }
    }
}
