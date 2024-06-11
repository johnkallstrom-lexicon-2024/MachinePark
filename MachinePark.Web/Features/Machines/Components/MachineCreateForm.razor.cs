using MachinePark.Web.Http.Services;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineCreateForm
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        [Parameter]
        public string? Title { get; set; }

        public MachineCreateDto Model { get; set; } = new();

        private async Task Submit()
        {
        }
    }
}
