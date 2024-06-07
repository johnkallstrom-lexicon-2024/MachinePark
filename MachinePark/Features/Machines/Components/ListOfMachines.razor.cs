using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features.Machines.Components
{
    public partial class ListOfMachines
    {
        [Inject]
        public IRepository<Machine> MachineRepository { get; set; } = default!;

        public IEnumerable<Machine> Machines { get; set; } = [];

        protected override void OnInitialized()
        {
            Machines = MachineRepository.Get();
        }
    }
}
