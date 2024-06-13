namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineTable
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public IEnumerable<MachineDto> Model { get; set; } = [];

        public string[] Errors { get; set; } = default!;

        protected override async Task OnInitializedAsync()
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

        private async Task Refresh()
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
    }
}
