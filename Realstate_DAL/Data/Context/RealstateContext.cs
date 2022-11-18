
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_realestate.Data.Models;



namespace Realstate_DAL;

public class RealstateContext : IdentityDbContext<UserClass, IdentityRole<Guid> ,Guid>
{

    #region tables
    public DbSet<Advertisement> Advertisements { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;
<<<<<<< Updated upstream
    public DbSet<CompanyUser> CompanyUsers { get; set; } = null!;
   
=======

    public DbSet<Chat> Chat { get; set; } = null!;
>>>>>>> Stashed changes
    #endregion

    public RealstateContext(DbContextOptions<RealstateContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<CompanyUser>().HasKey(u => new { u.UserID, u.CompanyID });
        builder.Entity<UserClass>().ToTable("Users");
    }
}
