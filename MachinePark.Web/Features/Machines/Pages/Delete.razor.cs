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

        public MachineDto MachineToDelete { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            await GetMachine();
        }

        private async Task GetMachine()
        {
            try
            {
                var result = await HttpService.GetAsync<MachineDto>($"{Endpoints.Machines}/{Id}");
                if (result.Succeeded && result.Data != null)
                {
                    MachineToDelete = result.Data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task DeleteMachine()
        {
            var result = await HttpService.DeleteAsync($"{Endpoints.Machines}/{Id}");
            if (result.Succeeded)
            {
                NavigationManager.NavigateTo("/dashboard", forceLoad: true);
            }
        }
    }
}
