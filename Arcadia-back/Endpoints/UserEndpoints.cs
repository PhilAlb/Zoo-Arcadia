using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class UserEndpoints
{
    const string url = "/admin/users";

    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, async (IRepository<User> userRepository) =>
        {
            return true;
        });

        app.MapPost(url, async (IRepository<User> userRepository, [FromBody] User user) =>
        {
            return true;
        });

        app.MapPut(url + "/{id}", async (IRepository<User> userRepository, [FromBody] User user, int id) =>
        {
            return true;
        });

        app.MapDelete(url + "/{id}", async (IRepository<User> userRepository, int id) =>
        {
            return true;
        });
    }
}