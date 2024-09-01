using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public static class UserEndpoints
{
    const string url = "/admin/users";

    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet(url, [Authorize(Roles = "Admin")] async (IRepository<User> userRepository, UserManager<User> userManager) =>
        {
            var users = await userRepository.GetAllAsync();
            var userDtos = new List<UserDto>();

            foreach (var u in users)
            {
                var newUser = new UserDto(){
                    Id = u.Id,
                    Email = u.Email,
                    Name = u.Name,
                    Password = string.Empty,
                    Surname = u.Surname,
                };
                var role = await userManager.GetRolesAsync(u);
                newUser.Role = Enum.Parse<Role>(role.First());

                userDtos.Add(newUser);
            }

            return userDtos;
        }).WithTags("Admin - Users");

        app.MapPost(url, [Authorize(Roles = "Admin")] async (SignInManager<User> signInManager, UserManager<User> userManager, [FromBody] UserDto userDto) =>
        {
            var user = new User()
            {
                UserName = userDto.Email,
                Email = userDto.Email,
                Name = userDto.Name,
                Surname = userDto.Surname,
            };

            var hasher = new PasswordHasher<User>();
            user.PasswordHash = hasher.HashPassword(user, userDto.Password);

            var result = await userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, userDto.Role.ToString());
                return true;
            }

            return false;
        }).WithTags("Admin - Users");

        app.MapPut(url + "/{id}", [Authorize(Roles = "Admin")] async (IRepository<User> userRepository, UserManager<User> userManager, [FromBody] UserDto userDto, string id) =>
        {
            var userToUpdate = await userRepository.GetByIdAsync(id);
            if (userToUpdate == null) return false;

            userToUpdate.Name = userDto.Name;
            userToUpdate.Surname = userDto.Surname;

            if (userToUpdate.Email != userDto.Email)
            {
                userToUpdate.Email = userDto.Email;
                userToUpdate.UserName = userDto.Email;
            }

            var hasher = new PasswordHasher<User>();
            userToUpdate.PasswordHash = hasher.HashPassword(userToUpdate, userDto.Password);

            // Update user role
            var currentRole = (await userManager.GetRolesAsync(userToUpdate)).FirstOrDefault();
            if (currentRole != null && currentRole != userDto.Role.ToString())
            {
                await userManager.AddToRoleAsync(userToUpdate, userDto.Role.ToString());
                await userManager.RemoveFromRoleAsync(userToUpdate, currentRole);
            }

            await userRepository.UpdateAsync(userToUpdate, id);
            return true;
        }).WithTags("Admin - Users");

        app.MapDelete(url + "/{id}", [Authorize(Roles = "Admin")] async (IRepository<User> userRepository, string id) =>
        {
            await userRepository.DeleteAsync(id);
            return true;
        }).WithTags("Admin - Users");
    }
}