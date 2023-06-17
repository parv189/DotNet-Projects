using Project1.Code.Interfaces;
using Project1.Models;

namespace Project1.Code.SqlServer
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(NaukriContext _context):base(_context) { }
    }
}
