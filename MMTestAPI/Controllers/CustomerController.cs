using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MMTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MMTestController : ControllerBase
    {

        private readonly ILogger<MMTestController> _logger;

        public MMTestController(ILogger<MMTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCustomers(bool isActive)
        {
           return Ok(new List<Customer>());
        }

        
        [HttpPost]
        public IActionResult RemoveCustomer(bool softDelete, int customerId)
        {
           return Ok();
        }
    }
}
