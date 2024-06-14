namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineTable
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public IEnumerable<MachineDto> Model { get; set; } = default!;

        public bool Loading { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            await GetMachines();
        }

        private async Task Refresh()
        {
            await GetMachines();
        }

        private async Task GetMachines()
        {
            Loading = true;

            var machines = await HttpService.GetAsync<IEnumerable<MachineDto>>(Endpoints.Machines);
            if (machines != null)
            {
                Model = machines;
            }

            Loading = false;
        }
    }
}
