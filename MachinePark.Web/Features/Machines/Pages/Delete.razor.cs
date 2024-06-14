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

        public MachineDto Model { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            await GetMachine();
        }

        private async Task GetMachine()
        {
            var machine = await HttpService.GetAsync<MachineDto>($"{Endpoints.Machines}/{Id}");
            if (machine != null)
            {
                Model = machine;
            }
        }

        private async Task DeleteMachine()
        {
            await HttpService.DeleteAsync($"{Endpoints.Machines}/{Id}");
            NavigationManager.NavigateTo("/dashboard", forceLoad: true);
        }
    }
}
