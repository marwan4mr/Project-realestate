
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_realestate.Data.Models;



namespace Realstate_DAL;

public class RealstateContext : IdentityDbContext
{

    #region tables
    public DbSet<Advertisement> Advertisements { get; set; } = null!;
    public DbSet<UserClass> UserClasses { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;
    #endregion

    public RealstateContext(DbContextOptions<RealstateContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
