﻿
namespace Realstate_BL;

public class UserReadDTO
{
    public Guid UserId { get; set; }
    public string UserName { get; set; } = "";
    public string UserPassword { get; set; } = "";
    public string UserEmail { get; set; } = "";
    public int UserPhoneNumber { get; set; }
    public string UserImage { get; set; } = "";
    public ICollection<CompanyUsersReadDTO> Companies { get; set; } = new HashSet<CompanyUsersReadDTO>();
}
