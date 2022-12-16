

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiPool.Data;
using ApiPool.Models.Toons;
using ApiPool.Models.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiPool.Controllers.Toons
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ToonsPolicy")]
    public class ToonsController : ControllerBase
    {
        private readonly ApiPoolContext _context;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;

        public ToonsController(IConfiguration configuration,
            ApiPoolContext context,
            IWebHostEnvironment env,
            IMapper mapper
        )
        {
            _configuration = configuration;
            _context = context;
            _env = env;
            _mapper = mapper;
        }

        // GET: api/toons
        [HttpGet]
        public async Task<ActionResult<List<Toon>?>> GetToons()
        {
            if (_context.Toons == null)
            {
                return NotFound();
            }

            var toons = await _context.Toons
            .OrderBy(_ => _.FirstName + _.LastName)
            .ToListAsync();

            toons = Helpers.AdjustPictureUrlInList(Request, toons);

            return toons;
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Toon>> GetPeople(int id)
        {
            var person = await _context.Toons.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(person.PictureUrl))
            {
                person.PictureUrl = Helpers.AdjustPictureUrl(Request, person.PictureUrl);
            }
            return person;
        }

        // PUT: api/People/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeople(int id, Toon toon)
        {
            if (string.IsNullOrEmpty(toon.FirstName)
                || string.IsNullOrEmpty(toon.LastName)
                || string.IsNullOrEmpty(toon.Occupation)
                || string.IsNullOrEmpty(toon.Gender)
                || string.IsNullOrEmpty(toon.PictureUrl)
            ) return BadRequest("FirstName, LastName, Occupation, Gender and PictureUrl are required.");

            if (id != toon.Id)
            {
                return BadRequest();
            }

            if (!string.IsNullOrEmpty(toon.PictureUrl))
            {
                if (!Helpers.IsPictureInLegitToonList(toon.PictureUrl, _env, Request))
                {
                    return BadRequest("Picture must be among those at /api/pictures");
                }
            }

            toon.FirstName = WebUtility.HtmlEncode(toon.FirstName);
            toon.LastName = WebUtility.HtmlEncode(toon.LastName);
            toon.Occupation = WebUtility.HtmlEncode(toon.Occupation);
            toon.Gender = WebUtility.HtmlEncode(toon.Gender);
            toon.PictureUrl = WebUtility.HtmlEncode(toon.PictureUrl);

            _context.Entry(toon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
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

        // POST: api/People
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Toon>> PostPeople(Toon people)
        {
            string strMaxTblSize = _configuration["MaxTableSize"];

            if (!string.IsNullOrEmpty(strMaxTblSize) && _context.Toons.Count() > Convert.ToInt32(strMaxTblSize))
            {
                return BadRequest($"Number of records exceeded {strMaxTblSize}.");
            }

            if (string.IsNullOrEmpty(people.FirstName)
                || string.IsNullOrEmpty(people.LastName)
                || string.IsNullOrEmpty(people.Occupation)
                || string.IsNullOrEmpty(people.Gender)
                || string.IsNullOrEmpty(people.PictureUrl)
                ) return BadRequest("FirstName, LastName, Occupation, Gender and PictureUrl are required.");

            if (!string.IsNullOrEmpty(people.PictureUrl))
            {
                if (!Helpers.IsPictureInLegitToonList(people.PictureUrl, _env, Request))
                {
                    return BadRequest("Picture must be among those at /api/pictures");
                }
            }

            people.FirstName = WebUtility.HtmlEncode(people.FirstName);
            people.LastName = WebUtility.HtmlEncode(people.LastName);
            people.Occupation = WebUtility.HtmlEncode(people.Occupation);
            people.Gender = WebUtility.HtmlEncode(people.Gender);
            people.PictureUrl = WebUtility.HtmlEncode(people.PictureUrl);

            _context.Toons.Add(people);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return CreatedAtAction("GetPeople", new { id = people.Id }, people);
        }

        [HttpPost("{id:int}/vote")]
        public async Task<ActionResult<Toon>> IncrementVote(int id)
        {
            var people = await _context.Toons.FindAsync(id);

            if (people == null)
            {
                return NotFound();
            }
            people.Votes = ++people.Votes;
            //_context.Entry(people).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return people;
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Toon>> DeletePeople(int id)
        {
            var people = await _context.Toons.FindAsync(id);
            if (people == null)
            {
                return NotFound();
            }

            _context.Toons.Remove(people);
            await _context.SaveChangesAsync();

            return people;
        }

        private bool PeopleExists(int id)
        {
            return _context.Toons.Any(e => e.Id == id);
        }
    }

}