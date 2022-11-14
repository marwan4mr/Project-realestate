using Microsoft.EntityFrameworkCore;
using Project_realestate.Data.Models;

namespace realestate_DAL
{
    public class RealstateContext:DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; } 
            
        public RealstateContext(DbContextOptions<RealstateContext> options):base(options)
        {
          
        }
    }
}
