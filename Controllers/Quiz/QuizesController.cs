using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Quiz;

namespace ApiPool.Controllers.Quiz
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        private readonly ApiPoolContext _context;

        public QuizzesController(ApiPoolContext context)
        {
            _context = context;
        }

        // GET: api/Quizes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizResult>>> GetQuizResult()
        {
          if (_context.QuizResult == null)
          {
              return NotFound();
          }
            return await _context.QuizResult.ToListAsync();
        }

        // GET: api/Quizes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuizResult>> GetQuizResult(int id)
        {
          if (_context.QuizResult == null)
          {
              return NotFound();
          }
            var quizResult = await _context.QuizResult.FindAsync(id);

            if (quizResult == null)
            {
                return NotFound();
            }

            return quizResult;
        }

        // PUT: api/Quizes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuizResult(int id, QuizResult quizResult)
        {
            if (id != quizResult.QuizResultId)
            {
                return BadRequest();
            }

            _context.Entry(quizResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizResultExists(id))
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

        // POST: api/Quizes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QuizResult>> PostQuizResult(QuizResult quizResult)
        {
          if (_context.QuizResult == null)
          {
              return Problem("Entity set 'ApiPoolContext.QuizResult'  is null.");
          }
            _context.QuizResult.Add(quizResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuizResult", new { id = quizResult.QuizResultId }, quizResult);
        }

        // DELETE: api/Quizes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizResult(int id)
        {
            if (_context.QuizResult == null)
            {
                return NotFound();
            }
            var quizResult = await _context.QuizResult.FindAsync(id);
            if (quizResult == null)
            {
                return NotFound();
            }

            _context.QuizResult.Remove(quizResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuizResultExists(int id)
        {
            return (_context.QuizResult?.Any(e => e.QuizResultId == id)).GetValueOrDefault();
        }
    }
}
