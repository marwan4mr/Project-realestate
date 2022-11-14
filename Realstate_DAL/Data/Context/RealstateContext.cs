using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_realestate.Data.Models;
using Realstate_DAL;

namespace realestate_DAL
{
    public class RealstateContext:IdentityDbContext
    {

        #region tables
        public DbSet<Advertisement> Advertisements { get; set; } 
        public DbSet<UserClass> userClasses { get; set; }
        #endregion

        public RealstateContext(DbContextOptions<RealstateContext> options):base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
