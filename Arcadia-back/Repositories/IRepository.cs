namespace Arcadia_back.Repositories
{
    // This is a generic repository, for specific cases override the base methods
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity, object id);
        Task DeleteAsync(object id);
    }
}
