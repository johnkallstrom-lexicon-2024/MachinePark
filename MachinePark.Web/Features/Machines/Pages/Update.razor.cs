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
            await GetMachineTypes();
        }

        private async Task Submit()
        {
            var result = await HttpService.PutAsync($"{Endpoints.Machines}/{Id}", Model);
            if (result.Succeeded)
            {
                NavigationManager.NavigateTo("/dashboard");
            }
        }

        private async Task GetMachineTypes()
        {
            var result = await HttpService.GetAsync<IEnumerable<MachineTypeDto>>(Endpoints.MachineTypes);
            if (result.Succeeded)
            {
                MachineTypes = result.Data;
            }
        }
    }
}
