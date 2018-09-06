using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todoApi.Models;

namespace todoApi.Controllers
{
   // [Produces("application/json")]
    [Route("api/city")]
    [ApiController]
    public class CityController : Controller
    {
        public readonly ApplicationDbContext context;

        public CityController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return context.Cyties.ToList();
        }
    }
}