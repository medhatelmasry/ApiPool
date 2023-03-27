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
    [EnableCors("ApiPolicy")]
    public class PicturesController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<PicturesController> _logger;
        public PicturesController(ILogger<PicturesController> logger,IWebHostEnvironment env)
        {
            _logger = logger;
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