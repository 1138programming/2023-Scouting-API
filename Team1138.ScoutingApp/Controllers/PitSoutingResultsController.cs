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
    public class PitSoutingResultsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PitSoutingResultsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PitSoutingResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PitSoutingResult>>> GetPitSoutingResults()
        {
            return await _context.PitSoutingResults.ToListAsync();
        }

        // GET: api/PitSoutingResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PitSoutingResult>> GetPitSoutingResult(int id)
        {
            var pitSoutingResult = await _context.PitSoutingResults.FindAsync(id);

            if (pitSoutingResult == null)
            {
                return NotFound();
            }

            return pitSoutingResult;
        }

        // PUT: api/PitSoutingResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPitSoutingResult(int id, PitSoutingResult pitSoutingResult)
        {
            if (id != pitSoutingResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(pitSoutingResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PitSoutingResultExists(id))
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

        // POST: api/PitSoutingResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PitSoutingResult>> PostPitSoutingResult(PitSoutingResult pitSoutingResult)
        {
            _context.PitSoutingResults.Add(pitSoutingResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPitSoutingResult", new { id = pitSoutingResult.Id }, pitSoutingResult);
        }

        // DELETE: api/PitSoutingResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePitSoutingResult(int id)
        {
            var pitSoutingResult = await _context.PitSoutingResults.FindAsync(id);
            if (pitSoutingResult == null)
            {
                return NotFound();
            }

            _context.PitSoutingResults.Remove(pitSoutingResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PitSoutingResultExists(int id)
        {
            return _context.PitSoutingResults.Any(e => e.Id == id);
        }
    }
}
