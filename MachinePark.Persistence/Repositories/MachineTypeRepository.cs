using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;

namespace MachinePark.Persistence.Repositories
{
    public class MachineTypeRepository : IRepository<MachineType>
    {
        private readonly MachineParkDataStore _store;

        public MachineTypeRepository(MachineParkDataStore store)
        {
            _store = store;
        }

        public IEnumerable<MachineType> Get() => _store.MachineTypes;

        public MachineType? GetById<T>(T id)
        {
            throw new NotImplementedException();
        }

        public void Create(MachineType entity)
        {
            throw new NotImplementedException();
        }
    }
}
