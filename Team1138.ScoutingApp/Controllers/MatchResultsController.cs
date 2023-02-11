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
    public class MatchResultsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MatchResultsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MatchResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatchResult>>> GetMatchResult()
        {
            return await _context.MatchResult.ToListAsync();
        }

        // GET: api/MatchResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchResult>> GetMatchResult(int id)
        {
            var matchResult = await _context.MatchResult.FindAsync(id);

            if (matchResult == null)
            {
                return NotFound();
            }

            return matchResult;
        }

        // PUT: api/MatchResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatchResult(int id, MatchResult matchResult)
        {
            if (id != matchResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(matchResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchResultExists(id))
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

        // POST: api/MatchResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MatchResult>> PostMatchResult(MatchResult matchResult)
        {
            _context.MatchResult.Add(matchResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatchResult", new { id = matchResult.Id }, matchResult);
        }

        // DELETE: api/MatchResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatchResult(int id)
        {
            var matchResult = await _context.MatchResult.FindAsync(id);
            if (matchResult == null)
            {
                return NotFound();
            }

            _context.MatchResult.Remove(matchResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MatchResultExists(int id)
        {
            return _context.MatchResult.Any(e => e.Id == id);
        }
    }
}
