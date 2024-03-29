﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationSystem_API.Data;
using System.Security.Cryptography;

namespace ReservationSystem_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacilityController : ControllerBase
    {
        private readonly ILogger<FacilityController> _logger;
        private readonly AppDbContext _dbContext;

        public FacilityController(ILogger<FacilityController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetFacilities")]
        public ActionResult<IEnumerable<Facility>> GetFacilities()
        {
            return Ok(_dbContext.Facilities.ToList());
        }

        [HttpGet("{idx}", Name = "GetFacility")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Facility> GetFacility(int idx)
        {
            var facility = _dbContext.Facilities.Find(idx);
            return facility == null ? NotFound() : Ok(facility);
        }

        [HttpPost(Name = "AddFacility")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult AddFacility(Facility facility)
        {
            _dbContext.Facilities.Add(facility);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name = "DeleteFacility")]
        public ActionResult DeleteFacility(int idx)
        {
            var facility = _dbContext.Facilities.Find(idx);
            if (facility == null)
                return NotFound();

            _dbContext.Facilities.Remove(facility);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
