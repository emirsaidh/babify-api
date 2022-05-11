using Microsoft.AspNetCore.Identity;

namespace babify_api.Models.Authentication
{
    public class UserRole : IdentityRole<int>
    {
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
