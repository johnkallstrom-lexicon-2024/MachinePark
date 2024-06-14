namespace MachinePark.Web.Services
{
    public interface IHttpService
    {
        Task<TData?> GetAsync<TData>(string url);
        Task PostAsync(string url, object value);
        Task PutAsync(string url, object value);
        Task DeleteAsync(string url);
    }
}
