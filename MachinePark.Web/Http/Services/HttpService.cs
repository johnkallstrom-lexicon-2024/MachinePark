namespace MachinePark.Web.Http.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result<TData>> GetAsync<TData>(string url)
        {
            var httpResponse = await _httpClient.GetAsync(url);
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadFromJsonAsync<TData>();
                if (json != null)
                {
                    return Result<TData>.Success(json);
                }
            }

            return Result<TData>.Failure();

        }

        public async Task<Result> PostAsync(string url, object value)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, value);
            if (httpResponse.IsSuccessStatusCode)
            {
                return Result.Success();
            }

            return Result.Failure();
        }

        public async Task<Result<TData>> PostAsync<TData>(string url, object value)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, value);
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadFromJsonAsync<TData>();
                if (json != null)
                {
                    return Result<TData>.Success(json);
                }
            }

            return Result<TData>.Failure();
        }

        public async Task<Result> DeleteAsync(string url)
        {
            var httpResponse = await _httpClient.DeleteAsync(url);
            if (httpResponse.IsSuccessStatusCode)
            {
                return Result.Success();
            }

            return Result.Failure();
        }
    }
}
