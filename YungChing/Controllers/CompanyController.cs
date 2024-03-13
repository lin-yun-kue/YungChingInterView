using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YungChing.EFModel;

namespace YungChing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyContext _companyContext;

        public CompanyController(CompanyContext context) 
        {
            _companyContext = context;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Company> Get() {
            return _companyContext.Company.ToList();
        }
    }
}
