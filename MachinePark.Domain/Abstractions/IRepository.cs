namespace MachinePark.Domain.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity?> GetByIdAsync<T>(T id);
        Task CreateAsync(TEntity entity);
    }
}
