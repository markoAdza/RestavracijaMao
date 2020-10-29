using web.Models;
using Microsoft.EntityFrameworkCore;

namespace web.Data
{
    public class SeminarskaContext : DbContext
    {
        public SeminarskaContext(DbContextOptions<SeminarskaContext> options) : base(options)
        {
        }
        
        public DbSet<Menu> Menu { get; set; }
    }
}