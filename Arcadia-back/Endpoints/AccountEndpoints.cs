using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public static class AccountEndpoints
{
    public static void MapAccountEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/login", async ([FromBody] LoginModel model, SignInManager<User> signInManager) =>
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            return result.Succeeded;
        }).WithTags("Account");

        app.MapPost("/logout", [Authorize] async (HttpContext context, SignInManager<User> signInManager) =>
        {
            await signInManager.SignOutAsync();
            return true;
        }).WithTags("Account");

        app.MapGet("/isAuthenticated", (HttpContext context) =>
        {
            if (context.User.Identity?.IsAuthenticated == true)
            {
                var roles = context.User.Claims
                    .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role)
                    .Select(c => c.Value);

                return new { IsAuthenticated = true, Role = roles.First() };
            }

            return new { IsAuthenticated = false, Role = "" };
        }).WithTags("Account");
    }
}