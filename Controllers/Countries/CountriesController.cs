using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Countries;
using Microsoft.AspNetCore.Cors;

namespace ApiPool.Controllers.Countries
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiPolicy")]
    public class CountriesController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public CountriesController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(string id)
        {
            var country = await _context.Countries.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(string id, Country country)
        {
            if (id != country.CountryName)
            {
                return BadRequest();
            }

            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            _context.Countries.Add(country);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CountryExists(country.CountryName!))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCountry", new { id = country.CountryName }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(string id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryExists(string id)
        {
            return _context.Countries.Any(e => e.CountryName == id);
        }
    }
}
