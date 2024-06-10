namespace MachinePark.Web.Services
{
    public interface IHttpService
    {
        Task<T?> GetAsync<T>(string url);
    }
}
