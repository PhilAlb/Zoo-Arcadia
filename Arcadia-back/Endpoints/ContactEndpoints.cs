using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;

public static class ContactEndpoints
{
    const string url = "/admin/contacts";

    public static void MapContactEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, [Authorize(Roles = "Admin,Employee")] async (IRepository<Contact> contactRepository) =>
        {
            var contacts = await contactRepository.GetAllAsync();
            return contacts;
        }).WithTags("Admin - Contacts");

        app.MapDelete(url + "/{id}", [Authorize(Roles = "Admin, Employee")] async (IRepository<Contact> contactRepository, int id) =>
       {
           await contactRepository.DeleteAsync(id);
           return true;
       }).WithTags("Admin - Contacts");
    }
}