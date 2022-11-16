
namespace Realstate_DAL;
public interface IUserRepo : IGenericRepo<UserClass>
{
    List<UserClass> GetUsersWithCompany();
 
}
