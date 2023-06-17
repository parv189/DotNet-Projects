using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Code.Interfaces;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository company;

        public CompanyController(ICompanyRepository company)
        {
            this.company = company;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetCompanys()
        {
            return company.Index().ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Company> GetCompany(int id)
        {
            var c= company.Find(x=>x.CompanyId==id).FirstOrDefault();
            if (c == null)
            {
                return NotFound();
            }
            return c;
        }

        [HttpPut("{id}")]
        public ActionResult<Company> PutCompany(int id, Company request)
        {
            try
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                var Updatedcompany = company.Update(request);
                return Updatedcompany;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult<Company> Add(Company request) { 
            return company.Add(request);
        }

        [HttpDelete("{id}")]
        public ActionResult<Company> DeleteCompany(int id)
        {
            try
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                var c = company.Find(x => x.CompanyId == id).FirstOrDefault();
                var deletedCompany = company.Delete(c);
                return deletedCompany;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private bool CompanyExists(int id)
        {
            return company.IsExist(x => x.CompanyId == id);
        }
    }
}
