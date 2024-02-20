using Microsoft.EntityFrameworkCore;
using ValoRank.Models;

namespace ValoRank.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Member> Members { get; set; }
    }
}
