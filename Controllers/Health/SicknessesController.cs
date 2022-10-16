using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Health;

namespace ApiPool.Controllers.Health
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicknessesController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public SicknessesController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Sicknesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sickness>>> GetSicknesses()
        {
          if (_context.Sicknesses == null)
          {
              return NotFound();
          }
            return await _context.Sicknesses
            .OrderBy(_ => _.SicknessName)
            .ToListAsync();
        }

        // GET: api/Sicknesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sickness>> GetSickness(int id)
        {
          if (_context.Sicknesses == null)
          {
              return NotFound();
          }
            var sickness = await _context.Sicknesses.FindAsync(id);

            if (sickness == null)
            {
                return NotFound();
            }

            return sickness;
        }

        // PUT: api/Sicknesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSickness(int id, Sickness sickness)
        {
            if (id != sickness.SicknessId)
            {
                return BadRequest();
            }

            _context.Entry(sickness).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SicknessExists(id))
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

        // POST: api/Sicknesses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sickness>> PostSickness(Sickness sickness)
        {
          if (_context.Sicknesses == null)
          {
              return Problem("Entity set 'ApiPoolContext.Sicknesses'  is null.");
          }
            _context.Sicknesses.Add(sickness);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSickness", new { id = sickness.SicknessId }, sickness);
        }

        // DELETE: api/Sicknesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSickness(int id)
        {
            if (_context.Sicknesses == null)
            {
                return NotFound();
            }
            var sickness = await _context.Sicknesses.FindAsync(id);
            if (sickness == null)
            {
                return NotFound();
            }

            _context.Sicknesses.Remove(sickness);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SicknessExists(int id)
        {
            return (_context.Sicknesses?.Any(e => e.SicknessId == id)).GetValueOrDefault();
        }
    }
}
