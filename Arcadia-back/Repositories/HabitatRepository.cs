using Arcadia_back.models;
using ArcadiaBack;
using Microsoft.EntityFrameworkCore;

namespace Arcadia_back.Repositories
{
    public class HabitatRepository : Repository<Habitat>, IHabitatRepository
    {
        private readonly AppDbContext _dbContext;

        public HabitatRepository(AppDbContext dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public override async Task<IEnumerable<Habitat>> GetAllAsync()
        {
            try
            {
                var a = await _dbContext.Set<Habitat>()
                    .Include(a => a.Animals)
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