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

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpService.DeleteAsync($"{Endpoints.Machines}/{Id}");
            if (result.Succeeded)
            {
                NavigationManager.NavigateTo("/dashboard");
            }
        }
    }
}
