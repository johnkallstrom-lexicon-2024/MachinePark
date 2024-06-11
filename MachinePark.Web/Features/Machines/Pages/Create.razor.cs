namespace MachinePark.Web.Features.Machines.Pages
{
    public partial class Create
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public MachineCreateDto Model { get; set; } = new();

        private async Task Submit()
        {
            var result = await HttpService.PostAsync(Endpoints.Machines, Model);
            if (result.Succeeded)
            {
                NavigationManager.NavigateTo("/dashboard");
            }
        }
    }
}
