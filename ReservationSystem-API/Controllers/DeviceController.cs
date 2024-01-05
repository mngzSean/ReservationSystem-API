using Microsoft.AspNetCore.Mvc;

namespace ReservationSystem_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private static int _id = 0;

        private readonly ILogger<DeviceController> _logger;

        public DeviceController(ILogger<DeviceController> logger)
        {
            _logger = logger;
        }

        [HttpPost("counter/issue")]
        public int PostCounterIssue()
        {
            return ++_id;
        }

        [HttpGet("counter")]
        public int GetCounterNumber()
        {
            return _id;
        }
    }
}
