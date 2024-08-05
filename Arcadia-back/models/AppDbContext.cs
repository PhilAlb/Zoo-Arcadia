using ArcadiaBack;
using Microsoft.EntityFrameworkCore;

namespace Arcadia_back.models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KFS7SQD;Database=arcadia;Trusted_Connection=True;Encrypt=False;");
        }

    }
}