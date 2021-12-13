using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaymentProcessor.Rules;

namespace PaymentProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentProcessorController : ControllerBase
    {
        

        private readonly ILogger<PaymentProcessorController> _logger;

        private RulesManager _rulesManager;
        public PaymentProcessorController(ILogger<PaymentProcessorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        //TODO return result
        public bool PostAsync()
        {
            return true ;
        }
    }
}
