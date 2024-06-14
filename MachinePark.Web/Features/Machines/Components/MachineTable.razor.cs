namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineTable
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public IEnumerable<MachineDto> Model { get; set; } = default!;

        public bool Loading { get; set; } = false;
        public string[] Errors { get; set; } = default!;

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

            try
            {
                var result = await HttpService.GetAsync<IEnumerable<MachineDto>>(Endpoints.Machines);
                if (result.Succeeded)
                {
                    Model = result.Data;
                }
                else
                {
                    Errors = result.Errors;
                }
            }
            catch (Exception ex)
            {
                Errors = [ex.Message];
            }

            Loading = false;
        }
    }
}
