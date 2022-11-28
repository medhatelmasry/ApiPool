using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Restaurants;
using ApiPool.Models.Utils;

namespace ApiPool.Controllers.Restaurants
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public RestaurantsController(ApiPoolContext context, IWebHostEnvironment env)
        {
            _context = context;
        }

        // GET: api/Restaurants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurant>?>> GetRestaurants()
        {
          if (_context.Restaurants == null)
          {
              return NotFound();
          }
          var restaurants = await _context.Restaurants
          .OrderBy(_ => _.RestaurantName)
          .ToListAsync();

          restaurants = Helpers.AdjustPictureUrlInList(Request, restaurants);

          return restaurants;
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
          if (_context.Restaurants == null)
          {
              return NotFound();
          }
            var restaurant = await _context.Restaurants.FindAsync(id);
            

            if (restaurant == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(restaurant.LogoUrl))
            {
                restaurant.LogoUrl = Helpers.AdjustPictureUrl(Request, restaurant.LogoUrl);
            }

            return restaurant;
        }

        // PUT: api/Restaurants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurant restaurant)
        {
            if (id != restaurant.RestaurantId)
            {
                return BadRequest();
            }

            _context.Entry(restaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(id))
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

        // POST: api/Restaurants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(Restaurant restaurant)
        {
          if (_context.Restaurants == null)
          {
              return Problem("Entity set 'ApiPoolContext.Restaurants'  is null.");
          }
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestaurant", new { id = restaurant.RestaurantId }, restaurant);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            if (_context.Restaurants == null)
            {
                return NotFound();
            }
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET api/patients/3/medication
        [HttpGet("{id:int}/menu")]
        public async Task<IActionResult> GetMedications(int id)
        {
            var menuItems = await _context.MenuItems
              .Where(m => m.RestaurantId == id)
              .ToListAsync();

            if (menuItems == null)
                return NotFound();

            return Ok(menuItems);
        }


        private bool RestaurantExists(int id)
        {
            return (_context.Restaurants?.Any(e => e.RestaurantId == id)).GetValueOrDefault();
        }
    }
}
