using ArcadiaBack;

namespace Arcadia_back.Repositories
{
    public interface IHabitatRepository : IRepository<Habitat>
    {
        new Task<IEnumerable<Habitat>> GetAllAsync();
    }
}
