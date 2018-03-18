using Microsoft.EntityFrameworkCore;

namespace dojoLeague.Models
{
    public class DojoLeagueContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DojoLeagueContext(DbContextOptions<DojoLeagueContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Ninja> Ninjas { get; set; }
    }
}
