using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace stripe_payment_testing.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripePaymentController : ControllerBase
    {
        public StripePaymentController()
        {
            
        }

        [HttpGet("part-1")]
        public async Task<IActionResult> CreateCheckout()
        {
            return Ok();
        }

        [HttpGet("part-2")]
        public async Task<IActionResult> CreateCustomer()
        {
            return Ok();
        }
    }
}
