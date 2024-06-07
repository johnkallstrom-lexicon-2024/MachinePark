using AutoMapper;
using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Features.Machines.ViewModels;

namespace MachinePark.Services
{
    public class MachineService : IMachineService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Machine> _repository;

        public MachineService(IRepository<Machine> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<MachineViewModel> GetMachines()
        {
            var machines = _repository.Get();
            return _mapper.Map<IEnumerable<MachineViewModel>>(machines);
        }
    }
}
