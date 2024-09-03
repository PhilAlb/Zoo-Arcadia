using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class TestimonyEndpoints
{
    const string url = "/admin/testimonies";

    public static void MapTestimonyEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, [Authorize(Roles = "Admin, Employee")] async (IRepository<Testimony> testimonyRepository) =>
        {
            return await testimonyRepository.GetAllAsync(); 
        }).WithTags("Admin - Testimonies");

        app.MapPost(url, [Authorize(Roles = "Admin")] async (IRepository<Testimony> testimonyRepository, [FromBody] Testimony testimony) =>
        {
            await testimonyRepository.AddAsync(testimony);
            return true;
        }).WithTags("Admin - Testimonies");

        app.MapPut(url + "/{id}", [Authorize(Roles = "Admin, Employee")] async (IRepository<Testimony> testimonyRepository, [FromBody] Testimony testimony, int id) =>
        {
            var testimonyToUpdate = await testimonyRepository.GetByIdAsync(id);
            if (testimonyToUpdate == null) return false;

            testimonyToUpdate.Pseudo = testimony.Pseudo;
            testimonyToUpdate.Message = testimony.Message;
            testimonyToUpdate.IsValidated = testimony.IsValidated; 

            await testimonyRepository.UpdateAsync(testimonyToUpdate, id);
            return true;
        }).WithTags("Admin - Testimonies");

        app.MapDelete(url + "/{id}", [Authorize(Roles = "Admin, Employee")] async (IRepository<Testimony> testimonyRepository, int id) =>
        {
            await testimonyRepository.DeleteAsync(id);
            return true;
        }).WithTags("Admin - Testimonies");
    }
}