using Microsoft.AspNetCore.Mvc;
using ReservationSystem_API.Data;

namespace ReservationSystem_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private static int _id = 0;

        private readonly ILogger<DeviceController> _logger;
        private readonly AppDbContext _dbContext;

        public DeviceController(ILogger<DeviceController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
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

        [HttpGet(Name ="GetDevices")]
        public ActionResult<IEnumerable<Device>> GetDevices() 
        {
            return Ok(_dbContext.Devices.ToList());
        }

        [HttpGet("{idx}", Name="GetDevice")]
        public ActionResult<Device> GetDevice(int idx)
        {
            var device = _dbContext.Devices.Find(idx);
            return device == null ? NotFound() : Ok(device);
        }

        [HttpPost(Name ="AddDevice")]
        public ActionResult AddDevice(Device device) 
        {
            _dbContext.Devices.Add(device);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name ="DeleteDevice")]
        public ActionResult DeleteDevice(int idx) 
        {
            var device = _dbContext.Devices.Find(idx);
            if(device == null)
                return NotFound();

            _dbContext.Devices.Remove(device);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
