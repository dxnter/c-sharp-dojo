using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Models
{
    public class WeddingPlannerContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public WeddingPlannerContext(DbContextOptions<WeddingPlannerContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
