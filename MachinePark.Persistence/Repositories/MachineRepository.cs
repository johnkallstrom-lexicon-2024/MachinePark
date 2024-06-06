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
    }
}
