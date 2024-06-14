namespace MachinePark.Web.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TData?> GetAsync<TData>(string url)
        {
            TData? data = default;

            var httpResponse = await _httpClient.GetAsync(url);
            if (httpResponse.IsSuccessStatusCode)
            {
                data = await httpResponse.Content.ReadFromJsonAsync<TData>();
            }

            return data;
        }

        public async Task PostAsync(string url, object value) => await _httpClient.PostAsJsonAsync(url, value);

        public async Task PutAsync(string url, object value) => await _httpClient.PutAsJsonAsync(url, value);

        public async Task DeleteAsync(string url) => await _httpClient.DeleteAsync(url);
    }
}
