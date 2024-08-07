using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class AnimalEndpoints
{
    const string url = "/admin/animals";

    public static void MapAnimalEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, async (IAnimalRepository animalRepository) =>
        {
            var animals = await animalRepository.GetAllAsync();
            var animalDtos = new List<AnimalDto>();

            foreach (var a in animals)
            {
                animalDtos.Add(new AnimalDto()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Race = a.Race,
                    ImageUrl = a.ImageUrl,
                    AssociatedHabitatTitle = a.AssociatedHabitat?.Title
                });
            }

            return animalDtos;
        });

        app.MapPost(url, async (IAnimalRepository animalRepository, [FromForm] AnimalDto animalDto) =>
        {
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "assets/images/animals");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // Build the full path to save the file
            var fileName = Path.GetFileName(animalDto?.Image?.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            // Save the file to a backend folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await animalDto.Image.CopyToAsync(stream);
            }
            var fileUrl = $"assets/images/animals/{fileName}";

            var animal = new Animal()
            {
                Name = animalDto.Name,
                ImageUrl = fileUrl,
                Race = animalDto.Race,
                AssociatedHabitatId = animalDto.AssociatedHabitatId,
            };

            await animalRepository.AddAsync(animal);

            return true;
        }).DisableAntiforgery();

        app.MapPut(url + "/{id}", async (IAnimalRepository animalRepository, [FromBody] AnimalDto animal, int id) =>
        {
            var animalToUpdate = await animalRepository.GetByIdAsync(id);
            if (animalToUpdate == null) return false;

            animalToUpdate.Name = animal.Name;
            animalToUpdate.Race = animal.Race;
            animalToUpdate.AssociatedHabitatId = animal.AssociatedHabitatId;

            await animalRepository.UpdateAsync(animalToUpdate, id);
            return true;
        });

        app.MapDelete(url + "/{id}", async (IAnimalRepository animalRepository, int id) =>
        {
            await animalRepository.DeleteAsync(id);
            return true;
        });
    }
}