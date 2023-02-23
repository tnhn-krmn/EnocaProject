using EnocaProject.Business.Abstract;
using EnocaProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("CompanyList")]
        public IActionResult Get()
        {
            var result = _companyService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CompanyAdd")]
        public IActionResult Add(Company company)
        {
            var result = _companyService.Add(company);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CompanyUpdate")]
        public IActionResult Update(Company company)
        {
            var result = _companyService.Update(company);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CompanyDelete")]
        public IActionResult Delete(Company company)
        {
            var result = _companyService.Delete(company);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
