using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessRulesEngine.Managers;

namespace BusinessRulesEngine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessRulesEngineController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BusinessRulesEngineController> _logger;

        public BusinessRulesEngineController(ILogger<BusinessRulesEngineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            return 0;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(IPayment payment)
        {
            var paymentManager = new PaymentManager();

            await paymentManager.Manage(payment);

            return Ok();
        }
    }
}
