using Microsoft.EntityFrameworkCore;

namespace DatingApp.Models
{
    public partial class DatingAppContext : DbContext
    {
        public DatingAppContext() { }

        public DatingAppContext(DbContextOptions<DatingAppContext> options) 
            : base(options) 
        {
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
