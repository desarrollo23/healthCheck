using HealthCheck.Contracts.Engine;
using Microsoft.AspNetCore.Mvc;

namespace HealthCheck.Service
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private IHealthCheckEngine _healthCheckEngine;

        public HealthController(IHealthCheckEngine healthCheckEngine)
        {
            _healthCheckEngine = healthCheckEngine;
        }

        [HttpGet]
        public IActionResult Check()
        {
            var response = _healthCheckEngine.CheckStatusServices();
            return Ok(response);
        }
    }
}
