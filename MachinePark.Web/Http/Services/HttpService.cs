namespace MachinePark.Web.Http.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> GetAsync<TData>(string url)
        {
            var httpResponse = await _httpClient.GetAsync(url);
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadFromJsonAsync<TData>();
                if (json != null)
                {
                    return Result<TData>.Succeeded(json);
                }
            }

            return Result.Failure();

        }

        public async Task<IResult> PostAsync(string url, object value)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, value);
            if (httpResponse.IsSuccessStatusCode)
            {
                return Result.Succeeded();
            }

            return Result.Failure();
        }

        public async Task<IResult> PostAsync<TData>(string url, object value)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, value);
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadFromJsonAsync<TData>();
                if (json != null)
                {
                    return Result<TData>.Succeeded(json);
                }
            }

            return Result.Failure();
        }
    }
}
