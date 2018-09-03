using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todoApi.Services;

namespace todoApi.Controllers
{
   // [Produces("application/json")]
    [Route("api/city")]
    [ApiController]
    public class CityController : Controller
    {
        [HttpGet("{name}")]
        public ActionResult<string> GetByName(string name)
        {
            if (name == null)
            {
                return NotFound();
            }
            else if (name == "Obregon")
            {
                return "{data: [33.5,30,32,34,33,31,28,28,31,30,30,25,24,29], label: 'Obregon'}";
            }
            else if (name == "Hermosillo")
            {
                return "{data: [30,32,30,33.5,30,32,34,33,31,30.5,31,33,30.5,31], label: 'Hermosillo'}";
            }
            else if (name == "Navojoa")
            {
                return "{data: [28,39,30,30,31,32,33.5,30.5,32,34,33,31,30,30], label: 'Navojoa'}";
            }
            else if (name == "Nogales")
            {
                return "{data: [30,32,30,31,29,30,30.5,29,33.5,30,32,34,33,31], label: 'Nogales'}"; ;
            }
            else
            {
                return NotFound();
            }
        }
    }
}