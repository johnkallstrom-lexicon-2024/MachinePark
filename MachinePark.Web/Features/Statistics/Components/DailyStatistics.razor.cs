namespace MachinePark.Web.Features.Statistics.Components
{
    public partial class DailyStatistics
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public StatisticsDto Model { get; set; } = default!;

        public bool Loading { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            await GetStatistics();
        }

        private async Task Refresh()
        {
            await GetStatistics();
        }

        private async Task GetStatistics()
        {
            Loading = true;

            var statistics = await HttpService.GetAsync<StatisticsDto>(Endpoints.Statistics);
            if (statistics != null)
            {
                Model = statistics;
            }

            Loading = false;
        }
    }
}
