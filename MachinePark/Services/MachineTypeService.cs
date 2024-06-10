using AutoMapper;
using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Features.Machines.ViewModels;

namespace MachinePark.Services
{
    public class MachineTypeService : IMachineTypeService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<MachineType> _repository;

        public MachineTypeService(IRepository<MachineType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<MachineTypeViewModel> GetMachineTypes()
        {
            var machineTypes = _repository.Get();
            return _mapper.Map<IEnumerable<MachineTypeViewModel>>(machineTypes);
        }
    }
}
