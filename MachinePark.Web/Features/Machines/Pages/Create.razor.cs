namespace MachinePark.Web.Features.Machines.Pages
{
    public partial class Create
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public MachineCreateDto Model { get; set; } = new();

        public IEnumerable<MachineTypeDto> MachineTypes { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            await GetMachineTypes();
        }

        private async Task Submit()
        {
            await HttpService.PostAsync(Endpoints.Machines, Model);
            NavigationManager.NavigateTo("/dashboard", forceLoad: true);
        }

        private async Task GetMachineTypes()
        {
            var machineTypes = await HttpService.GetAsync<IEnumerable<MachineTypeDto>>(Endpoints.MachineTypes);
            if (machineTypes != null)
            {
                MachineTypes = machineTypes;
            }
        }
    }
}
