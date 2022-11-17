
namespace Realstate_DAL;
public interface IUserRepo : IGenericRepo<UserClass>
{
    void Add(UserClass user);
    List<UserClass> GetUsersWithCompany();
 
}
