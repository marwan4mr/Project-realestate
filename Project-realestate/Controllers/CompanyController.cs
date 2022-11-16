
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realstate_BL;

namespace GraduationProjectITI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyManager _companyManager;

        public CompanyController(ICompanyManager companyManager)
        {
            _companyManager = companyManager;
        }
        /*******************************************************  GET: api/Companies  ********************************************/
        [HttpGet]
        public ActionResult<IEnumerable<CompanyReadDTO>> GetDoctors()
        {
            return _companyManager.GetAllCompanies();
        }
        /*******************************************************  GET: api/Company/id  ********************************************/
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<CompanyReadDTO> GetDoctor(Guid id)
        {
            var companyDTO = _companyManager.GetCompanyById(id);

            if (companyDTO == null)
            {
                return NotFound();
            }

            return companyDTO;
        }
        /*******************************************************  Put: api/Company  ********************************************/
        [HttpPut]
        public ActionResult PutUser(CompanyWriteDTO CompanyDTO)
        {
            var check = _companyManager.EditCompany(CompanyDTO);
            if (check)
            {
                return NoContent();
            }
            return BadRequest();
        }
        /*******************************************************  Post: api/Company  ********************************************/
        [HttpPost]
        public ActionResult<UserReadDTO> PostCompany(CompanyWriteDTO Company)
        {
            var CompanyDTO = _companyManager.AddCompany(Company);

            return CreatedAtAction("GetCompany", new { id = CompanyDTO.CompanyId }, CompanyDTO);
        }
        /*******************************************************  Delete: api/Company  ********************************************/
        [HttpDelete("{id}")]
        public ActionResult DeleteDoctor(Guid id)
        {
            _companyManager.DeleteCompany(id);
            return NoContent();
        }
        /*******************************************************  GET: api/CompanOfUsers  ********************************************/
        [HttpGet]
        [Route("companyOfUsers")]
        public ActionResult<List<CompanyReadDTO>> GetAllUsersCompany()
        {
            return _companyManager.GetCompanyWithUsers();
        }

    }
}
