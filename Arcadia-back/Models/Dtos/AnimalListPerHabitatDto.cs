using Arcadia_back.models.Dtos;

namespace ArcadiaBack
{
    public class AnimalListPerHabitatDto
    {
        public CardHabitatsDto Habitat { get; set; }
        public ICollection<AnimalDto> Animals { get; set; }
    }
}