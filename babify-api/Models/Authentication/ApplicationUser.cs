using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace babify_api.Models.Authentication
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Column(TypeName = "nvarchar(200)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? LastName { get; set; }
        public virtual ICollection<Baby>? Babies { get; set; }
    }
}