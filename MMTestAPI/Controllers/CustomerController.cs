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
        public IEnumerable<Customer> GetCustomers(bool isActive)
        {
           return Ok();
        }

        
        [HttpPost]
        public IActionResult RemoveCustomer(bool softDelete)
        {
           return Ok();
        }
    }
}
