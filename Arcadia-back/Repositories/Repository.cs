using Arcadia_back.models;
using Microsoft.EntityFrameworkCore;

namespace Arcadia_back.Repositories
{
    // This is a generic repository that includes basic CRUD operations
    // for specific use cases just override these
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public virtual async Task<T?> GetByIdAsync(object id)
        {
            try
            {
                return await _dbContext.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public virtual async Task AddAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Add(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public virtual async Task UpdateAsync(T entityToUpdate, object id)
        {
            try
            {
                var entity = await _dbContext.Set<T>().FindAsync(id);
                if (entity == null) return;

                _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }

        }

        public virtual async Task DeleteAsync(object id)
        {
            try
            {
                var entity = await _dbContext.Set<T>().FindAsync(id);
                if (entity == null) return;

                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }

        }
    }
}