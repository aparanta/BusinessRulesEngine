using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessRulesEngine.Managers;
using BusinessRulesEngine.Interfaces;

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
        private IPaymentManager _paymentManager;

        
        public BusinessRulesEngineController(ILogger<BusinessRulesEngineController> logger,IPaymentManager paymentManager)
        {
            _logger = logger;
            _paymentManager = paymentManager;
        }

        [HttpGet]
        public int Get()
        {
            return 0;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(IPayment payment)
        {
           

            await _paymentManager.Manage(payment);

            return Ok();
        }
    }
}
