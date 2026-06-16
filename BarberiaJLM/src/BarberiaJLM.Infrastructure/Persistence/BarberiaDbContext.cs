using Microsoft.EntityFrameworkCore;

namespace BarberiaJLM.Infrastructure.Persistence
{
    public class BarberiaDbContext(DbContextOptions<BarberiaDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BarberiaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
