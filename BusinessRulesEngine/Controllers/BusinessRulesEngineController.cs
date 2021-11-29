using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    }
}
