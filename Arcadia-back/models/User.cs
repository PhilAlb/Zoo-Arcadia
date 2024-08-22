using Microsoft.AspNetCore.Identity;

namespace ArcadiaBack
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}