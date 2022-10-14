using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Species;
using Microsoft.AspNetCore.Cors;

namespace ApiPool.Controllers.Species
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiPolicy")]
    public class OrganismsController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public OrganismsController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Organisms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organism>>> GetOrganisms()
        {
            return await _context.Organisms.ToListAsync();
        }

        // GET: api/Organisms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organism>> GetOrganism(int id)
        {
            var organism = await _context.Organisms.FindAsync(id);

            if (organism == null)
            {
                return NotFound();
            }

            return organism;
        }

        // PUT: api/Organisms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganism(int id, Organism organism)
        {
            if (id != organism.OrganismId)
            {
                return BadRequest();
            }

            _context.Entry(organism).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganismExists(id))
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

        // POST: api/Organisms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Organism>> PostOrganism(Organism organism)
        {
            _context.Organisms.Add(organism);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganism", new { id = organism.OrganismId }, organism);
        }

        // DELETE: api/Organisms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganism(int id)
        {
            var organism = await _context.Organisms.FindAsync(id);
            if (organism == null)
            {
                return NotFound();
            }

            _context.Organisms.Remove(organism);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrganismExists(int id)
        {
            return _context.Organisms.Any(e => e.OrganismId == id);
        }
    }
}
