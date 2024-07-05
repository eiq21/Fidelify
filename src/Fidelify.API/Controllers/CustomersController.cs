using Microsoft.AspNetCore.Mvc;

namespace Fidelify.API.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok("Customers");
        }
    }
}