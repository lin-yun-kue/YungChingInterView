using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YungChing.EFModel;
using YungChing.Service.Interface;

namespace YungChing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService service) 
        {
            _companyService = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Company> GetAll() {
            return _companyService.GetAllCompany();
        }

        [HttpGet]
        [Route("GetCompany/{id}")]
        public Company Get(int id)
        {
            return _companyService.GetCompany(id);
        }

        [HttpPost(Name = "Create")]
        public IActionResult Post(Company company)
         {
            var result = _companyService.CreateCompany(company);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Company company)
        {

            var result = _companyService.UpdateCompany(id, company);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _companyService.DeleteCompany(id);
            return Ok(result);
        }
    }
}
