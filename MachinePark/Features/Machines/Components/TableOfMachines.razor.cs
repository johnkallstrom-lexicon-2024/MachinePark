using MachinePark.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features.Machines.Components
{
    public partial class TableOfMachines
    {
        [Parameter]
        public IEnumerable<MachineViewModel> Model { get; set; } = [];
    }
}
