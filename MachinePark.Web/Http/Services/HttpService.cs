using MachinePark.Web.Http.Extensions;

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
                var data = await httpResponse.Content.ReadFromJsonAsync<TData>();
                if (data != null)
                {
                    return Result<TData>.Success(data);
                }
            }
            else
            {
                var info = httpResponse.ExtractInformation().Values.ToArray();
                return Result<TData>.Failure(info);
            }

            return Result<TData>.Failure();
        }

        public async Task<Result> PostAsync(string url, object value)
        {
            try
            {
                var httpResponse = await _httpClient.PostAsJsonAsync(url, value);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return Result.Success();
                }
                else
                {
                    var info = httpResponse.ExtractInformation().Values.ToArray();
                    return Result.Failure(info);
                }

            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }
        }

        public async Task<Result> PutAsync(string url, object value)
        {
            try
            {
                var httpResponse = await _httpClient.PutAsJsonAsync(url, value);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return Result.Success();
                }
                else
                {
                    var info = httpResponse.ExtractInformation().Values.ToArray();
                    return Result.Failure(info);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }
        }

        public async Task<Result> DeleteAsync(string url)
        {
            try
            {
                var httpResponse = await _httpClient.DeleteAsync(url);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return Result.Success();
                }
                else
                {
                    var info = httpResponse.ExtractInformation().Values.ToArray();
                    return Result.Failure(info);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }
        }
    }
}
