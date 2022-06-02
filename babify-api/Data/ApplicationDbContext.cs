using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using babify_api.Models.Authentication;
using babify_api.Models.TimerActivity;


namespace babify_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<ActivityModel> Activities { get; set; }


    }
}