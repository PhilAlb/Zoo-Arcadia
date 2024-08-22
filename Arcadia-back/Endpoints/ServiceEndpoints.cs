using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class ServiceEndpoints
{
    const string url = "/admin/services";

    public static void MapServiceEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, [Authorize(Roles = "Admin")] async (IRepository<Service> serviceRepository) =>
        {
            var services = await serviceRepository.GetAllAsync();
            var serviceDto = new List<ServiceDto>();

            foreach (var s in services)
            {
                serviceDto.Add(new ServiceDto(){
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Schedules = s.Schedules,
                    ImageUrl = s.ImageUrl,
                });
            }

            return serviceDto;
        });

        app.MapPost(url, [Authorize(Roles = "Admin")] async (IRepository<Service> serviceRepository, [FromForm] ServiceDto serviceDto) =>
        {
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "assets/images/services");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // Build the full path to save the file
            var fileName = Path.GetFileName(serviceDto?.Image?.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            // Save the file to a backend folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await serviceDto.Image.CopyToAsync(stream);
            }
            var fileUrl = $"assets/images/services/{fileName}";

            var service = new Service()
            {
                Title = serviceDto.Title,
                Description = serviceDto.Description,
                Schedules = serviceDto.Schedules,
                ImageVerticalPosition = "50%",
                ImageUrl = fileUrl,
            };

            await serviceRepository.AddAsync(service);
            return true;
        }).DisableAntiforgery();

        app.MapPut(url + "/{id}", [Authorize(Roles = "Admin")] async (IRepository<Service> serviceRepository, [FromBody] Service serviceDto, int id) =>
        {
            var serviceToUpdate = await serviceRepository.GetByIdAsync(id);
            if (serviceToUpdate == null) return false;

            serviceToUpdate.Title = serviceDto.Title;
            serviceToUpdate.Description = serviceDto.Description;
            serviceToUpdate.Schedules = serviceDto.Schedules;

            await serviceRepository.UpdateAsync(serviceToUpdate, id);
            return true;
        });

        app.MapDelete(url + "/{id}", [Authorize(Roles = "Admin")] async (IRepository<Service> serviceRepository, int id) =>
        {
            await serviceRepository.DeleteAsync(id);
            return true;
        });
    }
}