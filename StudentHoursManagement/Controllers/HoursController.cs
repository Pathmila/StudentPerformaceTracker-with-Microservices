using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentHoursManagement.Helper;
using StudentHoursManagement.Models;

namespace StudentHoursManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoursController : ControllerBase
    {
        private readonly HoursDBContext _context;

        public HoursController(HoursDBContext context)
        {
            _context = context;
        }

        // GET: api/Hours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hours>>> GetHours()
        {
            return await _context.Hours.ToListAsync();
        }

        // GET: api/Hours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hours>> GetHours(int id)
        {
            var hours = await _context.Hours.FindAsync(id);

            if (hours == null)
            {
                return NotFound();
            }

            return hours;
        }

        // POST: api/Hours
        [HttpPost]
        public async Task<ActionResult<Hours>> PostHours(Hours hours)
        {
            _context.Hours.Add(hours);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHours), new { id = hours.Id }, hours);
        }

        // PUT: api/Hours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHours(int id, Hours hours)
        {
            if (id != hours.Id)
            {
                return BadRequest();
            }

            _context.Entry(hours).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoursExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Hours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHours(int id)
        {
            var hours = await _context.Hours.FindAsync(id);
            if (hours == null)
            {
                return NotFound();
            }

            _context.Hours.Remove(hours);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HoursExists(int id)
        {
            return _context.Hours.Any(e => e.Id == id);
        }
    }
}
