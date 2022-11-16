
using Realstate_DAL;

public interface ICompanyRepo : IGenericRepo<Company>
{
    List<Company> GetAllUsersOfCompany();
   // Company? GetUserOfCompany(Guid id);

}
