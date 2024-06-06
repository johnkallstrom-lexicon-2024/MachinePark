namespace MachinePark.Domain.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();
    }
}
