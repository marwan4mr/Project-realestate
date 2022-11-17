using Microsoft.AspNetCore.Identity;
using Realstate_DAL;

public class UserClass : IdentityUser<Guid>
{
    public string? UserImage { get; set; } = "";
    public ICollection<CompanyUser> CompaniesUsers { get; set; } = new HashSet<CompanyUser>();
}
