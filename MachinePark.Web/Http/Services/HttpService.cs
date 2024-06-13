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
            try
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
            }
            catch (Exception ex)
            {
                return Result<TData>.Failure([ex.Message]);
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

            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }

            return Result.Failure();
        }

        public async Task<Result<TData>> PostAsync<TData>(string url, object value)
        {
            try
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
            }
            catch (Exception ex)
            {
                return Result<TData>.Failure([ex.Message]);
            }

            return Result<TData>.Failure();
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
            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }

            return Result.Failure();
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
            }
            catch (Exception ex)
            {
                return Result.Failure([ex.Message]);
            }

            return Result.Failure();
        }
    }
}
