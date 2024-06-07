using MachinePark.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features.Machines.Components
{
    public partial class TableOfMachines
    {
        [Parameter]
        public IEnumerable<Machine> Machines { get; set; } = [];
    }
}
