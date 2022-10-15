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
    public class MenusController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public MenusController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Menus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>?>> GetMenuItems()
        {
            if (_context.MenuItems == null)
            {
                return NotFound();
            }

            var menus = await _context.MenuItems.ToListAsync();

            menus = Helpers.AdjustPictureUrlInList(Request, menus);

            return menus;
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            if (_context.MenuItems == null)
            {
                return NotFound();
            }
            var menu = await _context.MenuItems.FindAsync(id);

            if (menu == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(menu.PictureUrl))
            {
                menu.PictureUrl = Helpers.AdjustPictureUrl(Request, menu.PictureUrl);
            }

            return menu;
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.MenuId)
            {
                return BadRequest();
            }

            _context.Entry(menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            if (_context.MenuItems == null)
            {
                return Problem("Entity set 'ApiPoolContext.MenuItems'  is null.");
            }
            _context.MenuItems.Add(menu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenu", new { id = menu.MenuId }, menu);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            if (_context.MenuItems == null)
            {
                return NotFound();
            }
            var menu = await _context.MenuItems.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.MenuItems.Remove(menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuExists(int id)
        {
            return (_context.MenuItems?.Any(e => e.MenuId == id)).GetValueOrDefault();
        }
    }
}
