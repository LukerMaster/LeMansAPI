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
    public class RaceEntryResultsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public RaceEntryResultsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceEntryResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceEntryResult>>> GetRaceEntryResults()
        {
            return await _context.RaceEntryResults.ToListAsync();
        }

        // GET: api/RaceEntryResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceEntryResult>> GetRaceEntryResult(int id)
        {
            var raceEntryResult = await _context.RaceEntryResults.FindAsync(id);

            if (raceEntryResult == null)
            {
                return NotFound();
            }

            return raceEntryResult;
        }

        // GET: api/RaceEntryResults/5
        [HttpGet("AllForRace/{id}")]
        public ActionResult<List<RaceEntryResult>> GetAllResultsForRace(int id)
        {
            var raceEntryResults = _context.RaceEntryResults
                .Include(x => x.Car)
                .Include(x => x.Drivers)
                .Include(x => x.Race)
                .Include(x => x.PitStops)
                .Where(x => x.Race.Id == id)
                .ToList();

            if (raceEntryResults == null)
            {
                return NotFound();
            }

            return raceEntryResults;
        }

        // PUT: api/RaceEntryResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceEntryResult(int id, RaceEntryResult raceEntryResult)
        {
            if (id != raceEntryResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceEntryResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceEntryResultExists(id))
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

        // POST: api/RaceEntryResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceEntryResult>> PostRaceEntryResult(RaceEntryResult raceEntryResult)
        {
            _context.RaceEntryResults.Add(raceEntryResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRaceEntryResult", new { id = raceEntryResult.Id }, raceEntryResult);
        }

        // DELETE: api/RaceEntryResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceEntryResult(int id)
        {
            var raceEntryResult = await _context.RaceEntryResults.FindAsync(id);
            if (raceEntryResult == null)
            {
                return NotFound();
            }

            _context.RaceEntryResults.Remove(raceEntryResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceEntryResultExists(int id)
        {
            return _context.RaceEntryResults.Any(e => e.Id == id);
        }
    }
}
