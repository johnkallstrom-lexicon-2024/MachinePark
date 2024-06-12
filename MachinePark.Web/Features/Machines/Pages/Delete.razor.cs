namespace MachinePark.Web.Features.Machines.Pages
{
    public partial class Delete
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        [Parameter]
        public Guid Id { get; set; }

        public MachineDto MachineToDelete { get; set; } = new();

        protected override async Task OnParametersSetAsync()
        {
            var result = await HttpService.GetAsync<MachineDto>($"{Endpoints.Machines}/{Id}");
            if (result.Succeeded)
            {
                MachineToDelete = result.Data;
            }
        }

        private async Task DeleteMachine()
        {
            var result = await HttpService.DeleteAsync($"{Endpoints.Machines}/{Id}");
            if (result.Succeeded)
            {
                NavigationManager.NavigateTo("/dashboard");
            }
        }
    }
}
