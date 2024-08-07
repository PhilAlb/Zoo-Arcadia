using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class ServiceEndpoints
{
    const string url = "/admin/services";

    public static void MapServiceEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, async (IRepository<Service> serviceRepository) =>
        {
            return true;
        });

        app.MapPost(url, async (IRepository<Service> serviceRepository, [FromBody] Service service) =>
        {
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "assets/images/services");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // Build the full path to save the file
            // var fileName = Path.GetFileName(service?.Image?.FileName);
            // var filePath = Path.Combine(uploadPath, fileName);

            // // Save the file to a backend folder
            // using (var stream = new FileStream(filePath, FileMode.Create))
            // {
            //     await animalDto.Image.CopyToAsync(stream);
            // }
            // var fileUrl = $"assets/images/services/{fileName}";

            return true;
        });

        app.MapPut(url + "/{id}", async (IRepository<Service> serviceRepository, [FromBody] Service service, int id) =>
        {
            return true;
        });

        app.MapDelete(url + "/{id}", async (IRepository<Service> serviceRepository, int id) =>
        {
            return true;
        });
    }
}