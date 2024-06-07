using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;

namespace MachinePark.Persistence.Repositories
{
    public class MachineRepository : IRepository<Machine>
    {
        private readonly MachineParkDataStore _store;

        public MachineRepository(MachineParkDataStore store)
        {
            _store = store;
        }

        public IEnumerable<Machine> Get() => _store.Machines;

        public Machine? GetById<Guid>(Guid id)
        {
            var machine = _store.Machines.FirstOrDefault(m => m.Id.Equals(id));
            return machine;
        }

        public void Create(Machine machine)
        {
            if (machine is null)
            {
                throw new ArgumentNullException(nameof(machine));
            }

            _store.Machines.Add(machine);
        }
    }
}
