using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeMansAPI;
using LeMansAPI.Models;

namespace LeMansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PitStopsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PitStopsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/PitStops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PitStop>>> GetPitStops()
        {
            return await _context.PitStops.ToListAsync();
        }

        // GET: api/PitStops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PitStop>> GetPitStop(int id)
        {
            var pitStop = await _context.PitStops.FindAsync(id);

            if (pitStop == null)
            {
                return NotFound();
            }

            return pitStop;
        }

        // PUT: api/PitStops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPitStop(int id, PitStop pitStop)
        {
            if (id != pitStop.Id)
            {
                return BadRequest();
            }

            _context.Entry(pitStop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PitStopExists(id))
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

        // POST: api/PitStops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PitStop>> PostPitStop(PitStop pitStop)
        {
            _context.PitStops.Add(pitStop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPitStop", new { id = pitStop.Id }, pitStop);
        }

        // DELETE: api/PitStops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePitStop(int id)
        {
            var pitStop = await _context.PitStops.FindAsync(id);
            if (pitStop == null)
            {
                return NotFound();
            }

            _context.PitStops.Remove(pitStop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PitStopExists(int id)
        {
            return _context.PitStops.Any(e => e.Id == id);
        }
    }
}
