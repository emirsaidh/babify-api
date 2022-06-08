using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using babify_api.Data;
using babify_api.Models.TimerActivity;
using babify_api.Models.Activity.TimerActivity;
using babify_api.Models.Activity;
using babify_api.Models;

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
        [Route("get-activity-with-discriminator")]
        public async Task<IActionResult> GetActivitiesWithDisc(string discriminator)
        {
            var activities = await _db.Activities
                .Where(c => c.Type == discriminator)
                .ToListAsync();
            return Ok(activities);
        }

        [HttpGet]
        [Route("get-activities-with-baby-id")]
        public async Task<IActionResult> GetActivitiesWithBabyId(int babyId)
        {
            var activityList = await _db.Activities
               .Where(c => c.BabyId == babyId)
               .ToListAsync();
            return Ok(activityList);
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

        [HttpPost]
        [Route("breast-feeding")]
        public async Task<IActionResult> PostBreastFeeding(BreastFeedingActivity breastFeedingActivity)
        {
            _db.Activities.Add(breastFeedingActivity);
            await _db.SaveChangesAsync();
            return Ok(breastFeedingActivity.ActivityId);
        }

        [HttpPost]
        [Route("bath")]
        public async Task<IActionResult> PostBath(BathActivity bathActivity)
        {
            _db.Activities.Add(bathActivity);
            await _db.SaveChangesAsync();
            return Ok(bathActivity.ActivityId);
        }

        [HttpPost]
        [Route("walk")]
        public async Task<IActionResult> PostWalk(WalkActivity walkActivity)
        {
            _db.Activities.Add(walkActivity);
            await _db.SaveChangesAsync();
            return Ok(walkActivity.ActivityId);
        }

        [HttpPost]
        [Route("pumping")]
        public async Task<IActionResult> PostPumping(PumpingActivity pumpingActivity)
        {
            _db.Activities.Add(pumpingActivity);
            await _db.SaveChangesAsync();
            return Ok(pumpingActivity.ActivityId);
        }

        [HttpPost]
        [Route("diaper")]
        public async Task<IActionResult> PostDiaper(DiaperActivity diaperActivity)
        {
            _db.Activities.Add(diaperActivity);
            await _db.SaveChangesAsync();
            return Ok(diaperActivity.ActivityId);
        }

        [HttpPost]
        [Route("bottle-milk")]
        public async Task<IActionResult> PostBottleMilk(BottleMilkActivity bottleMilkActivity)
        {

            _db.Activities.Add(bottleMilkActivity);
            await _db.SaveChangesAsync();
            return Ok(bottleMilkActivity.ActivityId);
        }

        [HttpPost]
        [Route("measure")]
        public async Task<IActionResult> PostMeasure(MeasureActivity measureMilkActivity)
        {
            _db.Activities.Add(measureMilkActivity);
            await _db.SaveChangesAsync();
            return Ok(measureMilkActivity.ActivityId);
        }

        [HttpPost]
        [Route("medication")]
        public async Task<IActionResult> PostMedication(MedicationActivity medicationActivity)
        {
            _db.Activities.Add(medicationActivity);
            await _db.SaveChangesAsync();
            return Ok(medicationActivity.ActivityId);
        }

        [HttpPost]
        [Route("vaccination")]
        public async Task<IActionResult> PostVaccination(VaccinationActivity vaccinationActivity)
        {
            _db.Activities.Add(vaccinationActivity);
            await _db.SaveChangesAsync();
            return Ok(vaccinationActivity.ActivityId);
        }


        [HttpGet]
        [Route("get-activities")]
        public async Task<IActionResult> GetActivitiesBabyIdDisc(int babyId, string discriminator)
        {
            var activityList = await _db.Activities
               .Where(c => c.BabyId == babyId && c.Type == discriminator)
               .ToListAsync();
            return Ok(activityList);
        }


    }
}
