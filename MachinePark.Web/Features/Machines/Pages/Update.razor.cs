namespace MachinePark.Web.Features.Machines.Pages
{
    public partial class Update
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        [Parameter]
        public Guid Id { get; set; }

        public MachineUpdateDto Model { get; set; } = new();

        public IEnumerable<MachineTypeDto> MachineTypes { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            await GetMachine();
            await GetMachineTypes();
        }

        private async Task GetMachine()
        {
            var machine = await HttpService.GetAsync<MachineDto>($"{Endpoints.Machines}/{Id}");
            if (machine != null)
            {
                Model.Name = machine.Name;
                Model.Status = machine.Status;
                Model.MachineTypeId = machine.Type.Id;
            }
        }

        private async Task GetMachineTypes()
        {
            var machineTypes = await HttpService.GetAsync<IEnumerable<MachineTypeDto>>(Endpoints.MachineTypes);
            if (machineTypes != null)
            {
                MachineTypes = machineTypes;
            }
        }

        private async Task Submit()
        {
            await HttpService.PutAsync($"{Endpoints.Machines}/{Id}", Model);
            NavigationManager.NavigateTo("/dashboard", forceLoad: true);
        }
    }
}
