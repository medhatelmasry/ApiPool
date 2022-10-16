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
    public class ProvincesController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public ProvincesController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Provincess
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Province>>> GetProvinces()
        {
            return await _context.Provinces
            .OrderBy(_ => _.Name)
            .ToListAsync();
        }

        // GET: api/Provincess/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Province>> GetProvince(int id)
        {
            var province = await _context.Provinces.FindAsync(id);

            if (province == null)
            {
                return NotFound();
            }

            return province;
        }

        // PUT: api/Provincess/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvince(int id, Province province)
        {
            if (id != province.ProvinceId)
            {
                return BadRequest();
            }

            _context.Entry(province).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceExists(id))
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

        // POST: api/Provincess
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Province>> PostProvince(Province province)
        {
            _context.Provinces.Add(province);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProvince", new { id = province.ProvinceId }, province);
        }

        // DELETE: api/Provincess/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvince(int id)
        {
            var province = await _context.Provinces.FindAsync(id);
            if (province == null)
            {
                return NotFound();
            }

            _context.Provinces.Remove(province);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProvinceExists(int id)
        {
            return _context.Provinces.Any(e => e.ProvinceId == id);
        }
    }
}
