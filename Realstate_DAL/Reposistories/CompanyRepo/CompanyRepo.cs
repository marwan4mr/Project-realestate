


using Microsoft.EntityFrameworkCore;
using Realstate_DAL;

public class CompanyRepo : GenericRepo<Company>, ICompanyRepo
{
    private readonly RealstateContext _context;

    public CompanyRepo(RealstateContext context) : base(context)
    {
        _context = context;
    }

    public List<Company> GetAllUsersOfCompany()
    {
        return _context.Companies.Include(c => c.Users).ToList();
    }
     
 

}
