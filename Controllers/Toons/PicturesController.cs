using System.Collections.Generic;
using ApiPool.Models.Toons;
using ApiPool.Models.Utils;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ApiPool.Controllers.Toons
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ToonsPolicy")]
    public class PicturesController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public PicturesController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<Picture> Get()
        {
            return Helpers.GetPictures(_env, Request).OrderBy(_ => _.Name);
        }
    }

}