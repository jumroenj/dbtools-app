using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBTUserApiCloud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly ILogger<VersionController> _logger;

        public VersionController(ILogger<VersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetApiVersion")]
        public string Get()
        {
            return "1.0.1";
        }
    }
}
