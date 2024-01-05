using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ReservationSystem_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacilityController : ControllerBase
    {
        private readonly ILogger<FacilityController> _logger;
        private static readonly Facility[] SampleFacilities =
        [
            new Facility
            {
                Idx = 0,
                Name = "병원",
                Location = "수원시",
                Purpose = "접수처"
            },
            new Facility
            {
                Idx = 1,
                Name = "체육관",
                Location = "화성시",
                Purpose = "운동"
            }
        ];

        public FacilityController(ILogger<FacilityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFacilities")]
        public IEnumerable<Facility> GetFacilities()
        {
            return SampleFacilities;
        }

        [HttpGet("{Idx}", Name = "GetFacility")]
        public Facility GetFacility(int Idx)
        {
            if(Idx < SampleFacilities.Length)
                return SampleFacilities[Idx];

            return new Facility { };
        }
    }
}
