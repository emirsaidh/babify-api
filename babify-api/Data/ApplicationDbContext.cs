using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using babify_api.Models.Authentication;

namespace Snekaer_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }

    }
}