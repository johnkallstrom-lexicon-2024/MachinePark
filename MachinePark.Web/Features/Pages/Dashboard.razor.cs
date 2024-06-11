using MachinePark.Web.Http.Services;
using Microsoft.AspNetCore.Components;

namespace MachinePark.Web.Features.Pages
{
    public partial class Dashboard
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public IEnumerable<MachineDto>? Machines { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            Machines = await HttpService.GetAsync<IEnumerable<MachineDto>>(Endpoints.Machines);
        }
    }
}
