using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using babify_api.Models.Authentication;
using babify_api.Models.TimerActivity;
using babify_api.Models.Activity.TimerActivity;
using babify_api.Models.Activity;
using babify_api.Models;

namespace babify_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<ApplicationUser> Parents { get; set; }
        public DbSet<Baby> Babies { get; set; }
        public DbSet<ActivityModel> Activities { get; set; }
        public DbSet<SleepActivity> SleepActivities { get; set; }
        public DbSet<TummyActivity> TummyActivities { get; set; }
        public DbSet<BreastFeedingActivity> BreastFeedingActivities { get; set; }
        public DbSet<BathActivity> BathActivities { get; set; }
        public DbSet<WalkActivity> WalkActivities { get; set; }
        public DbSet<PumpingActivity> PumpingActivities { get; set; }
        public DbSet<DiaperActivity> DiaperActivities { get; set; }
        public DbSet<BottleMilkActivity> BottleMilkActivities { get; set; }
        public DbSet<MeasureActivity> MeasureActivities { get; set; }
        public DbSet<MedicationActivity> MedicationActivities { get; set; }



    }
}