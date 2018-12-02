using Microsoft.AspNetCore.Identity;

namespace MokumokuIdentityApp.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
