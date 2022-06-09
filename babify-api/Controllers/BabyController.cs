using babify_api.Data;
using babify_api.Models;
using babify_api.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace babify_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BabyController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("get-all-babies")]
        public async Task<ActionResult<List<Baby>>> GetAll()
        {
            var babies = await _db.Babies.ToListAsync();
            return Ok(babies);
        }

        [HttpGet]
        [Route("get-baby-with-id")]
        public async Task<ActionResult<List<Baby>>> GetWithId(int id)
        {
            var baby = await _db.Babies
                .Where(c => c.Id == id)
                .ToListAsync();
            return Ok(baby);
        }

        [HttpGet]
        [Route("get-babies")]
        public async Task<IActionResult> GetBabies(int parentId)
        {
            var babyList = await _db.Babies
               .Where(c => c.ParentId1 == parentId || c.ParentId2 == parentId)
               .ToListAsync();
            return Ok(babyList);
        }

        [HttpPost]
        [Route("add-baby")]
        public async Task<IActionResult> PostBaby(Baby baby)
        {
            _db.Babies.Add(baby);
            await _db.SaveChangesAsync();
            return Ok(baby.Id);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteBaby(int id)
        {
            var babyToDelete = await _db.Babies.FindAsync(id);
            if (babyToDelete == null)
            {
                return NotFound();
            }
            _db.Babies.Remove(babyToDelete);
            await _db.SaveChangesAsync();
            return NoContent();
        }





    }
}
