using Microsoft.AspNetCore.Mvc;
using TestInterviewApp.Models;

[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly MidtransService _midtrans;

    public PaymentController(MidtransService midtrans)
    {
        _midtrans = midtrans;
    }

    [HttpPost("token/snap")]
    public async Task<IActionResult> CreateSnap([FromBody] SnapRequest req)
    {
        var payload = new
        {
            transaction_details = new
            {
                order_id = req.OrderId,
                gross_amount = req.Amount
            },
            customer_details = req.Customer
        };

        var response = await _midtrans.CreateSnapTransaction(payload);

        // Optional: log the response
        Console.WriteLine(response);

        return Content(response, "application/json");
    }
}
