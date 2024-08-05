using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;  // for NotMapped

namespace GameGalaxy.Models
{
    public class User: IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; } = null!;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
