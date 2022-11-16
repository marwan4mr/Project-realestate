
namespace Realstate_DAL;
public class Company
{
    public Guid CompanyId { get; set; }
    public string CompanyName { get; set; } = "";
    public string? CompanyImage { get; set; } = "";
    public string Companylocation { get; set; } = "";
    public int CompanyPhoneNumber { get; set; }
    public ICollection<UserClass> Users { get; set; } = new HashSet<UserClass>();


}
