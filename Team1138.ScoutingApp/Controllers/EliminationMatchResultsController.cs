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
    public class EliminationMatchResultsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EliminationMatchResultsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EliminationMatchResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EliminationMatchResults>>> GetEliminationMatchResults()
        {
            return await _context.EliminationMatchResults.ToListAsync();
        }

        // GET: api/EliminationMatchResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EliminationMatchResults>> GetEliminationMatchResults(int id)
        {
            var eliminationMatchResults = await _context.EliminationMatchResults.FindAsync(id);

            if (eliminationMatchResults == null)
            {
                return NotFound();
            }

            return eliminationMatchResults;
        }

        // PUT: api/EliminationMatchResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEliminationMatchResults(int id, EliminationMatchResults eliminationMatchResults)
        {
            if (id != eliminationMatchResults.Id)
            {
                return BadRequest();
            }

            _context.Entry(eliminationMatchResults).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EliminationMatchResultsExists(id))
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

        // POST: api/EliminationMatchResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EliminationMatchResults>> PostEliminationMatchResults(EliminationMatchResults eliminationMatchResults)
        {
            _context.EliminationMatchResults.Add(eliminationMatchResults);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEliminationMatchResults", new { id = eliminationMatchResults.Id }, eliminationMatchResults);
        }

        // DELETE: api/EliminationMatchResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEliminationMatchResults(int id)
        {
            var eliminationMatchResults = await _context.EliminationMatchResults.FindAsync(id);
            if (eliminationMatchResults == null)
            {
                return NotFound();
            }

            _context.EliminationMatchResults.Remove(eliminationMatchResults);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EliminationMatchResultsExists(int id)
        {
            return _context.EliminationMatchResults.Any(e => e.Id == id);
        }
    }
}
