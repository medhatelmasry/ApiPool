using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Foods;
using Microsoft.AspNetCore.Cors;

namespace ApiPool.Controllers.Foods
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiPolicy")]
    public class FoodCategoriesController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public FoodCategoriesController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/FoodCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodCategory>>> GetFoodCategories()
        {
            return await _context.FoodCategories
            .OrderBy(_ => _.Name)
            .ToListAsync();
        }

        // GET: api/FoodCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodCategory>> GetFoodCategory(int id)
        {
            var foodCategory = await _context.FoodCategories.FindAsync(id);

            if (foodCategory == null)
            {
                return NotFound();
            }

            return foodCategory;
        }

        // PUT: api/FoodCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodCategory(int id, FoodCategory foodCategory)
        {
            if (id != foodCategory.FoodCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(foodCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodCategoryExists(id))
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

        // POST: api/FoodCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodCategory>> PostFoodCategory(FoodCategory foodCategory)
        {
            _context.FoodCategories.Add(foodCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodCategory", new { id = foodCategory.FoodCategoryId }, foodCategory);
        }

        // DELETE: api/FoodCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodCategory(int id)
        {
            var foodCategory = await _context.FoodCategories.FindAsync(id);
            if (foodCategory == null)
            {
                return NotFound();
            }

            _context.FoodCategories.Remove(foodCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodCategoryExists(int id)
        {
            return _context.FoodCategories.Any(e => e.FoodCategoryId == id);
        }
    }
}
