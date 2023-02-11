using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team1138.ScoutingApp.Data;
using Team1138.ScoutingApp.Data.Entities;

namespace Team1138.ScoutingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PitScoutingResultsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PitScoutingResultsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PitScoutingResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PitScoutingResult>>> GetPitSoutingResults()
        {
            return await _context.PitSoutingResults.ToListAsync();
        }

        // GET: api/PitScoutingResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PitScoutingResult>> GetPitScoutingResult(int id)
        {
            var pitScoutingResult = await _context.PitSoutingResults.FindAsync(id);

            if (pitScoutingResult == null)
            {
                return NotFound();
            }

            return pitScoutingResult;
        }

        // PUT: api/PitScoutingResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPitScoutingResult(int id, PitScoutingResult pitScoutingResult)
        {
            if (id != pitScoutingResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(pitScoutingResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PitScoutingResultExists(id))
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

        // POST: api/PitScoutingResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PitScoutingResult>> PostPitScoutingResult(PitScoutingResult pitScoutingResult)
        {
            _context.PitSoutingResults.Add(pitScoutingResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPitScoutingResult", new { id = pitScoutingResult.Id }, pitScoutingResult);
        }

        // DELETE: api/PitScoutingResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePitScoutingResult(int id)
        {
            var pitScoutingResult = await _context.PitSoutingResults.FindAsync(id);
            if (pitScoutingResult == null)
            {
                return NotFound();
            }

            _context.PitSoutingResults.Remove(pitScoutingResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PitScoutingResultExists(int id)
        {
            return _context.PitSoutingResults.Any(e => e.Id == id);
        }
    }
}
