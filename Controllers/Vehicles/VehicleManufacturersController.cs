using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Vehicles;
using Microsoft.AspNetCore.Cors;

namespace ApiPool.Controllers.Vehicles
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiPolicy")]
    public class VehicleManufacturersController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public VehicleManufacturersController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/VehicleManufacturers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleManufacturer>>> GetVehicleManufacturers()
        {
            return await _context.VehicleManufacturers.ToListAsync();
        }

        // GET: api/VehicleManufacturers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleManufacturer>> GetVehicleManufacturer(string id)
        {
            var vehicleManufacturer = await _context.VehicleManufacturers.FindAsync(id);

            if (vehicleManufacturer == null)
            {
                return NotFound();
            }

            return vehicleManufacturer;
        }

        // PUT: api/VehicleManufacturers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleManufacturer(string id, VehicleManufacturer vehicleManufacturer)
        {
            if (id != vehicleManufacturer.VehicleManufacturerName)
            {
                return BadRequest();
            }

            _context.Entry(vehicleManufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleManufacturerExists(id))
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

        // POST: api/VehicleManufacturers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleManufacturer>> PostVehicleManufacturer(VehicleManufacturer vehicleManufacturer)
        {
            _context.VehicleManufacturers.Add(vehicleManufacturer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VehicleManufacturerExists(vehicleManufacturer.VehicleManufacturerName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVehicleManufacturer", new { id = vehicleManufacturer.VehicleManufacturerName }, vehicleManufacturer);
        }

        // DELETE: api/VehicleManufacturers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleManufacturer(string id)
        {
            var vehicleManufacturer = await _context.VehicleManufacturers.FindAsync(id);
            if (vehicleManufacturer == null)
            {
                return NotFound();
            }

            _context.VehicleManufacturers.Remove(vehicleManufacturer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehicleManufacturerExists(string id)
        {
            return _context.VehicleManufacturers.Any(e => e.VehicleManufacturerName == id);
        }
    }
}
