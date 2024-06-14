namespace MachinePark.Web.Features.Statistics.Components
{
    public partial class DailyStatistics
    {
        [Inject]
        public IHttpService HttpService { get; set; } = default!;

        public StatisticsDto Model { get; set; } = default!;

        public bool Loading { get; set; } = false;
        public string[] Errors { get; set; } = default!;

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

            try
            {
                var result = await HttpService.GetAsync<StatisticsDto>(Endpoints.Statistics);
                if (result.Succeeded)
                {
                    Model = result.Data;
                }
                else
                {
                    Errors = result.Errors;
                }
            }
            catch (Exception ex)
            {
                Errors = [ex.Message];
            }

            Loading = false;
        }
    }
}
