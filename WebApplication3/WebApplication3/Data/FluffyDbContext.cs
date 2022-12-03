using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class FluffyDbContext : DbContext
    {//zaduljitelno 
        public FluffyDbContext()
        {

        }
        public FluffyDbContext(DbContextOptions<FluffyDbContext> options) : base(options)
        {

        }
       public  DbSet<Cat> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
