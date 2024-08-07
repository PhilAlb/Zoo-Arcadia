using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Mvc;

public static class TestimonyEndpoints
{
    const string url = "/admin/testimonies";

    public static void MapTestimonyEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, async (IRepository<Testimony> testimonyRepository) =>
        {
            return true;
        });

        app.MapPost(url, async (IRepository<Testimony> testimonyRepository, [FromBody] Testimony testimony) =>
        {
            return true;
        });

        app.MapPut(url + "/{id}", async (IRepository<Testimony> testimonyRepository, [FromBody] Testimony testimony, int id) =>
        {
            return true;
        });

        app.MapDelete(url + "/{id}", async (IRepository<Testimony> testimonyRepository, int id) =>
        {
            return true;
        });
    }
}