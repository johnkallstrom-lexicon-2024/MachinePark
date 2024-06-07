using AutoMapper;
using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features
{
    public partial class Dashboard
    {
        [Inject]
        public IMapper Mapper { get; set; } = default!;

        [Inject]
        public IRepository<Machine> MachineRepository { get; set; } = default!;

        public IEnumerable<MachineViewModel> Machines { get; set; } = default!;

        protected override void OnInitialized()
        {
            var entities = MachineRepository.Get();
            Machines = Mapper.Map<IEnumerable<MachineViewModel>>(entities);
        }
    }
}
