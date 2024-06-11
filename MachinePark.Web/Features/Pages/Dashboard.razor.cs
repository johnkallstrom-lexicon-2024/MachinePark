using Microsoft.AspNetCore.Components;

namespace MachinePark.Web.Features.Pages
{
    public partial class Dashboard
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public IEnumerable<MachineDto> Machines { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpService.GetAsync<IEnumerable<MachineDto>>(Endpoints.Machines);
            if (result.Succeeded)
            {
                Machines = result.Data;
            }
            else
            {
                // Display error messages
            }
        }
    }
}
