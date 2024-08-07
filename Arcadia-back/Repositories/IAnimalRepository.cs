using ArcadiaBack;

namespace Arcadia_back.Repositories
{
    public interface IAnimalRepository : IRepository<Animal>
    {
        new Task<IEnumerable<Animal>> GetAllAsync();
    }
}
