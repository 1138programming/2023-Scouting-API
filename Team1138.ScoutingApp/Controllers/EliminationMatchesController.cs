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
    public class EliminationMatchesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EliminationMatchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EliminationMatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EliminationMatch>>> GetEliminationMatch()
        {
            return await _context.EliminationMatch.ToListAsync();
        }

        // GET: api/EliminationMatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EliminationMatch>> GetEliminationMatch(int id)
        {
            var eliminationMatch = await _context.EliminationMatch.FindAsync(id);

            if (eliminationMatch == null)
            {
                return NotFound();
            }

            return eliminationMatch;
        }

        // PUT: api/EliminationMatches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEliminationMatch(int id, EliminationMatch eliminationMatch)
        {
            if (id != eliminationMatch.ElimMatchID)
            {
                return BadRequest();
            }

            _context.Entry(eliminationMatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EliminationMatchExists(id))
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

        // POST: api/EliminationMatches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EliminationMatch>> PostEliminationMatch(EliminationMatch eliminationMatch)
        {
            _context.EliminationMatch.Add(eliminationMatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEliminationMatch", new { id = eliminationMatch.ElimMatchID }, eliminationMatch);
        }

        // DELETE: api/EliminationMatches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEliminationMatch(int id)
        {
            var eliminationMatch = await _context.EliminationMatch.FindAsync(id);
            if (eliminationMatch == null)
            {
                return NotFound();
            }

            _context.EliminationMatch.Remove(eliminationMatch);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EliminationMatchExists(int id)
        {
            return _context.EliminationMatch.Any(e => e.ElimMatchID == id);
        }
    }
}
