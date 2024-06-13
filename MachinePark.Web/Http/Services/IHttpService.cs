namespace MachinePark.Web.Http.Services
{
    public interface IHttpService
    {
        Task<Result<TData>> GetAsync<TData>(string url);
        Task<Result> PostAsync(string url, object value);
        Task<Result> PutAsync(string url, object value);
        Task<Result> DeleteAsync(string url);
    }
}
