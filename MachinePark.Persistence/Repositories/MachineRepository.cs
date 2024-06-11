using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace MachinePark.Persistence.Repositories
{
    public class MachineRepository : IRepository<Machine>
    {
        private readonly MachineParkDbContext _context;

        public MachineRepository(MachineParkDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Machine>> GetAsync()
        {
            var machines = await _context.Machines
                .Include(m => m.MachineType)
                .ToListAsync();

            return machines;
        }

        public async Task<Machine?> GetByIdAsync<Guid>(Guid id)
        {
            var machine = await _context.Machines
                .Include(mt => mt.MachineType)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));

            return machine;
        }

        public async Task<Machine> CreateAsync(Machine machine)
        {
            if (machine is null)
            {
                throw new ArgumentNullException(nameof(machine));
            }

            var entry = await _context.Machines.AddAsync(machine);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
