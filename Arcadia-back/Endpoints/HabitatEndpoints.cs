using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class HabitatEndpoints
{
    const string url = "/admin/habitats";

    public static void MapHabitatEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, async (IRepository<Habitat> habitatRepository) =>
        {
            var habitats = await habitatRepository.GetAllAsync();
            var habitatDto = new List<HabitatDto>();

            foreach (var h in habitats)
            {
                habitatDto.Add(new HabitatDto()
                {
                    Id = h.Id,
                    Title = h.Title,
                    Description = h.Description,
                    ImageUrl = h.ImageUrl,
                });
            }

            return habitatDto;
        });

        app.MapPost(url, async (IRepository<Habitat> habitatRepository, [FromForm] HabitatDto habitatDto) =>
        {
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "assets/images/habitats");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // Build the full path to save the file
            var fileName = Path.GetFileName(habitatDto?.Image?.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            // Save the file to a backend folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await habitatDto.Image.CopyToAsync(stream);
            }
            var fileUrl = $"assets/images/habitats/{fileName}";

            var habitat = new Habitat()
            {
                Title = habitatDto.Title,
                Description = habitatDto.Description,
                ImageVerticalPosition = "50%",
                ImageUrl = fileUrl,
                Animals = []
            };

            await habitatRepository.AddAsync(habitat);
            return true;
        }).DisableAntiforgery();

        app.MapPut(url + "/{id}", async (IRepository<Habitat> habitatRepository, [FromBody] HabitatDto habitat, int id) =>
        {
            var habitatToUpdate = await habitatRepository.GetByIdAsync(id);
            if (habitatToUpdate == null) return false;

            habitatToUpdate.Title = habitat.Title;
            habitatToUpdate.Description = habitat.Description;

            await habitatRepository.UpdateAsync(habitatToUpdate, id);
            return true;
        });

        app.MapDelete(url + "/{id}", async (IRepository<Habitat> habitatRepository, int id) =>
        {
            await habitatRepository.DeleteAsync(id);
            return true;
        });
    }
}