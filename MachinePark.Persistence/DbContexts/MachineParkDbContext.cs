using MachinePark.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MachinePark.Persistence.DbContexts
{
    public class MachineParkDbContext : DbContext
    {
        public MachineParkDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
