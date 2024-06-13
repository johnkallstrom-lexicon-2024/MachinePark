namespace MachinePark.Web.Features.Statistics.Components
{
    public partial class DailyStatistics
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public StatisticsDto Model { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            await GetStatistics();
        }

        private async Task GetStatistics()
        {
            var result = await HttpService.GetAsync<StatisticsDto>(Endpoints.Statistics);
            if (result.Succeeded)
            {
                Model = result.Data;
            }
        }
    }
}
