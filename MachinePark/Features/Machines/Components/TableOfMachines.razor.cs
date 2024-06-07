using Blazored.Modal.Services;
using MachinePark.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Features.Machines.Components
{
    public partial class TableOfMachines
    {
        [CascadingParameter]
        public IModalService ModalService { get; set; } = default!;

        [Parameter]
        public IEnumerable<Machine> Machines { get; set; } = [];

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
