using Microsoft.AspNetCore.Identity;
using Realstate_DAL;

public class UserClass : IdentityUser
{
    public Guid UserId { get; set; }
    public string Name { get; set; } = "";
    public string UserPassword { get; set; } = "";
    public string UserEmail { get; set; } = "";
    public int UserPhoneNumber { get; set; }
    public string? UserImage { get; set; } = "";
    public ICollection<Company> Companies { get; set; } = new HashSet<Company>();
}
