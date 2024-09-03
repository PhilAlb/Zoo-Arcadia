using Arcadia_back.models.Dtos;
using Arcadia_back.Repositories;
using ArcadiaBack;

public static class HabitatpageEndpoints
{
    public static void MapHabitatpageEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/habitats/animals", async (IHabitatRepository habitatRepository) =>
        {
            var habitats = await habitatRepository.GetAllAsync();
            var animalListDtos = new List<AnimalListPerHabitatDto>();

            foreach (var h in habitats)
            {
                var habitatDto = new CardHabitatsDto()
                {
                    Title = h.Title,
                    Description = h.Description,
                    Url = h.ImageUrl,
                    VerticalPosition = h.ImageVerticalPosition,
                };

                var animalsDto = new List<AnimalDto>();
                foreach (var a in h.Animals)
                {
                    animalsDto.Add(new AnimalDto()
                    {
                        Id = a.Id,
                        ImageUrl = a.ImageUrl,
                        Name = a.Name,
                        Race = a.Race
                    });
                }

                animalListDtos.Add(new AnimalListPerHabitatDto()
                {
                    Animals = animalsDto,
                    Habitat = habitatDto
                });
            }

            return animalListDtos;
        }).WithTags("Habitat page");

        app.MapPut("/habitats/animal/{id}", async (IAnimalRepository animalRepository, int id) => {
            var animalToUpdate = await animalRepository.GetByIdAsync(id);
            if (animalToUpdate == null) return false;

            animalToUpdate.Views++;
            await animalRepository.UpdateAsync(animalToUpdate, id);

            return true;
        }).WithTags("Habitat page");
    }
}
