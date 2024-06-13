namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineTable
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        [Parameter]
        public IEnumerable<MachineDto> Model { get; set; } = [];

        private async Task Refresh()
        {
            var result = await HttpService.GetAsync<IEnumerable<MachineDto>>(Endpoints.Machines);
            if (result.Succeeded)
            {
                Model = result.Data;
            }
        }
    }
}
