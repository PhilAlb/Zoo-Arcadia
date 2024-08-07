using Arcadia_back.models;
using ArcadiaBack;
using Microsoft.EntityFrameworkCore;

namespace Arcadia_back.Repositories
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {
        private readonly AppDbContext _dbContext;

        public AnimalRepository(AppDbContext dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<IEnumerable<Animal>> GetAllAsync()
        {
            try
            {
                var a = await _dbContext.Set<Animal>()
                    .Include(a => a.AssociatedHabitat)
                    .AsNoTracking()
                    .ToListAsync();
                return a;  
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}