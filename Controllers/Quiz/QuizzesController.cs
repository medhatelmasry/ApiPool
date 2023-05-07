using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPool.Data;
using ApiPool.Models.Quiz;
using ApiPool.Models.Utils;

namespace ApiPool.Controllers.Quiz
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        private readonly ApiPoolContext _context;
        private readonly IWebHostEnvironment _env;

        public QuizzesController(ApiPoolContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: api/Quizzes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizResult>>> GetQuizResult()
        {
            if (_context.QuizResult == null)
            {
                return NotFound();
            }
            return await _context.QuizResult.ToListAsync();
        }

        // GET: api/Quizzes/5
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

        // PUT: api/Quizzes/5
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
                if (!string.IsNullOrEmpty(quizResult.WebAppId))
                {
                    if (!Helpers.IsQuizInLegitGuidList(quizResult.WebAppId, _env, Request))
                    {
                        return BadRequest("Quiz WebAppIs must be among those approved.");
                    }
                }
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

        // POST: api/Quizzes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QuizResult>> PostQuizResult(QuizResult quizResult)
        {
            if (_context.QuizResult == null)
            {
                return Problem("Entity set 'ApiPoolContext.QuizResult'  is null.");
            }

            if (!string.IsNullOrEmpty(quizResult.WebAppId))
            {
                if (!Helpers.IsQuizInLegitGuidList(quizResult.WebAppId, _env, Request))
                {
                    return BadRequest("Quiz WebAppIs must be among those approved.");
                }
            }

            _context.QuizResult.Add(quizResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuizResult", new { id = quizResult.QuizResultId }, quizResult);
        }

        // DELETE: api/Quizzes/5
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
