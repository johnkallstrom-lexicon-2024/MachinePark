namespace MachinePark.Web.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T?> GetAsync<T>(string url)
        {
            var data = await _httpClient.GetFromJsonAsync<T>(url);
            return data;
        }
    }
}
