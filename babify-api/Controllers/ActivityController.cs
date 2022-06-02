using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using babify_api.Data;
using babify_api.Models.TimerActivity;
using babify_api.Models.Activity.TimerActivity;

namespace babify_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ActivityController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var activities = await _db.Activities.ToListAsync();
            return Ok(activities);
        }

        [HttpGet]
        [Route("get-activity-with-type")]
        public async Task<ActionResult<List<ActivityModel>>> Get(string activityType)
        {
            var activities = await _db.Activities
                .Where(c => c.Type == activityType)
                .ToListAsync();
            return Ok(activities);
        }

        [HttpPost]
        [Route("sleep")]
        public async Task<IActionResult> PostSleep(SleepActivity sleepActivity)
        {
            _db.Activities.Add(sleepActivity);
            await _db.SaveChangesAsync();
            return Ok(sleepActivity.ActivityId);
        }

        [HttpPost]
        [Route("tummy")]
        public async Task<IActionResult> PostTummy(TummyActivity tummyActivity)
        {
            _db.Activities.Add(tummyActivity);
            await _db.SaveChangesAsync();
            return Ok(tummyActivity.ActivityId);
        }


       
    }
}
