using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class AnimalEndpoints
{
    const string url = "/admin/animals";

    public static void MapAnimalEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, [Authorize(Roles = "Admin, Veterinarian")] async (IAnimalRepository animalRepository) =>
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
                    Views = a.Views,
                    ImageUrl = a.ImageUrl,
                    Comment = a.Comment,
                    AssociatedHabitatTitle = a.AssociatedHabitat?.Title
                });
            }

            return animalDtos;
        }).WithTags("Admin - Animals");

        app.MapPost(url, [Authorize(Roles = "Admin")] async (IAnimalRepository animalRepository, [FromForm] AnimalDto animalDto) =>
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
                Comment = animalDto.Comment ?? "",
                Views = 0,
            };

            await animalRepository.AddAsync(animal);

            return true;
        })
        .DisableAntiforgery()
        .WithTags("Admin - Animals");

        app.MapPut(url + "/{id}", [Authorize(Roles = "Admin, Veterinarian")] async (IAnimalRepository animalRepository, [FromBody] AnimalDto animal, int id) =>
        {
            var animalToUpdate = await animalRepository.GetByIdAsync(id);
            if (animalToUpdate == null) return false;

            if(animal.AssociatedHabitatId != null) animalToUpdate.AssociatedHabitatId = animal.AssociatedHabitatId;
            animalToUpdate.Name = animal.Name;
            animalToUpdate.Race = animal.Race;
            animalToUpdate.Views = animal.Views;
            animalToUpdate.Comment = animal.Comment ?? "";

            await animalRepository.UpdateAsync(animalToUpdate, id);
            return true;
        }).WithTags("Admin - Animals");

        app.MapDelete(url + "/{id}", [Authorize(Roles = "Admin")] async (IAnimalRepository animalRepository, int id) =>
        {
            await animalRepository.DeleteAsync(id);
            return true;
        }).WithTags("Admin - Animals");
    }
}