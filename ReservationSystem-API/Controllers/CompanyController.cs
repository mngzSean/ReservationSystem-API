using Microsoft.AspNetCore.Mvc;
using ReservationSystem_API.Data;

namespace ReservationSystem_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly AppDbContext _dbContext;

        public CompanyController(ILogger<CompanyController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetCompanies")]
        public ActionResult<IEnumerable<Company>> GetCompanies() 
        {
            return Ok(_dbContext.Companies.ToList());
        }

        [HttpGet("{Idx}", Name ="GetCompany")]
        public ActionResult<Company> GetCompany(int Idx) 
        {
            var company = _dbContext.Companies.Find(Idx);
            return company == null ? NotFound() : Ok(company);
        }

        [HttpPost(Name ="AddCompany")]
        public ActionResult AddCompany(Company company)
        {
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name ="DeleteCompany")]
        public ActionResult DeleteCompany(int Idx) 
        {
            var company = _dbContext.Companies.Find(Idx);
            if (company == null)
                return NotFound();

            _dbContext.Companies.Remove(company);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
