using Microsoft.EntityFrameworkCore;

namespace updatedLogin.Models
{
    public class UpdatedLoginContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public UpdatedLoginContext(DbContextOptions<UpdatedLoginContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
