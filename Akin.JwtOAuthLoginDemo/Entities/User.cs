using Microsoft.AspNetCore.Identity;

namespace Akin.JwtOAuthLoginDemo.Entities
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
