namespace MachinePark.Web.Http.Services
{
    public interface IHttpService
    {
        Task<IResult> GetAsync<TData>(string url);
        Task<IResult> PostAsync(string url, object value);
        Task<IResult> PostAsync<TData>(string url, object value);
    }
}
