namespace MachinePark.Web.Http.Services
{
    public interface IHttpService
    {
        Task<Result<TData>> GetAsync<TData>(string url);
        Task<Result> PostAsync(string url, object value);
        Task<Result<TData>> PostAsync<TData>(string url, object value);
        Task<Result> DeleteAsync(string url);
    }
}
