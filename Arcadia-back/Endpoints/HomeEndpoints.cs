using Arcadia_back.models.Dtos;
using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class HomeEndpoints
{
    public static void MapHomeEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/habitats", async (IRepository<Habitat> habitatRepository) =>
        {
            var habitats = await habitatRepository.GetAllAsync();
            var habitatsDto = new List<CardHabitatsDto>();

            foreach (var habitat in habitats)
            {
                habitatsDto.Add(new CardHabitatsDto()
                {
                    Title = habitat.Title,
                    Description = habitat.Description,
                    Url = habitat.ImageUrl,
                    VerticalPosition = habitat.ImageVerticalPosition
                });
            };

            return habitatsDto;
        });

        app.MapGet("/animals", async (IRepository<Animal> animalRepository) =>
        {
            var animals = await animalRepository.GetAllAsync();
            var animalsDto = new List<CarouselAnimalDto>();

            foreach (var animal in animals)
            {
                animalsDto.Add(new CarouselAnimalDto()
                {
                    AnimalName = animal.Name,
                    Url = animal.ImageUrl
                });
            };

            return animalsDto;
        });

        app.MapGet("/services", async (IRepository<Service> serviceRepository) =>
        {
            var services = await serviceRepository.GetAllAsync();
            var servicesDto = new List<CardServicesDto>();

            foreach (var service in services)
            {
                servicesDto.Add(new CardServicesDto()
                {
                    Title = service.Title,
                    Description = service.Description,
                    Url = service.ImageUrl,
                    VerticalPosition = service.ImageVerticalPosition,
                    Schedules = service.Schedules
                });
            };

            return servicesDto;
        });

        app.MapGet("/testimonies", async (IRepository<Testimony> testimonyRepository) =>
        {
            var testimonies = await testimonyRepository.GetAllAsync();
            var testimonyDtos = new List<CardTestimonyDto>();

            foreach (var testimony in testimonies)
            {
                testimonyDtos.Add(new CardTestimonyDto()
                {
                    Pseudo = testimony.Pseudo,
                    Message = testimony.Message,
                });
            };

            return testimonyDtos;
        });

        app.MapPost("/testimonies", async (IRepository<Testimony> testimonyRepository, [FromBody] Testimony testimony) =>
        {
            await testimonyRepository.AddAsync(testimony);
            return true;
        });
    }
}
