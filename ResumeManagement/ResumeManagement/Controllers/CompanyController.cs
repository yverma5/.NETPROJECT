using Microsoft.AspNetCore.Mvc;
using ResumeManagement.Core.Dtos;
using ResumeManagement.Service.Interface;

namespace ResumeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpPost]
        [Route("Create Company")]
        public async Task<IActionResult> CreateCompany(CreateCompanyDto dto)
        {
            var result = await companyService.CreateCompany(dto);
            if (result)
            {
                return Ok("Company Created Successfully!");
            }
            return BadRequest("Error!!");
        }
    }
}
