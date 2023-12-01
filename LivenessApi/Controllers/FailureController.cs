using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LivenessApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FailureController : ControllerBase
    {
        private readonly ILogger<FailureController> _logger;

        public FailureController(ILogger<FailureController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostFailure")]
        public IActionResult Post(bool failing)
        {
            HealthCheck.Failing = failing;
            return Accepted();
        }

        [HttpGet(Name = "GetFailure")]
        public IActionResult Get()
        {
            return Ok($"Failing: {HealthCheck.Failing}, FailedChecks: {HealthCheck.FailedChecks}, Machine Name: {Environment.MachineName}");
        }
    }
}
