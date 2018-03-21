using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Models {
    public class WeddingPlannerContext : DbContext {
        
        public WeddingPlannerContext(DbContextOptions<WeddingPlannerContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}