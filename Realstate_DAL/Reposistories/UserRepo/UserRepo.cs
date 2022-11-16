
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Realstate_DAL;
public class UserRepo : GenericRepo<UserClass> , IUserRepo
{
    private readonly RealstateContext _context;
 

    public UserRepo(RealstateContext context/*, UserManager<UserClass> userManager*/):base(context)
    {
        _context = context;
    }

    public List<UserClass> GetUsersWithCompany()
    {
        return _context.UserClasses.Include(p => p.Companies).ToList();
      
    }

}

