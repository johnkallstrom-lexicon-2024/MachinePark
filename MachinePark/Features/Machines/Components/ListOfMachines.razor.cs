using MachinePark.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features.Machines.Components
{
    public partial class ListOfMachines
    {
        [Parameter]
        public IEnumerable<Machine> Machines { get; set; } = [];

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
    }
}
