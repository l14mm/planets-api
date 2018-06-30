using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanetsAPI.Data;

namespace PlanetsAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlanetsController : Controller
    {
        private readonly PlanetContext _context;

        public PlanetsController(PlanetContext context)
        {
            _context = context;
        }
        
        [HttpGet("{name}")]
        public IActionResult GetInfo(string name)
        {
            var planet = _context.Planets
                            .Where(b => b.Name == name)
                            .FirstOrDefault();

            if (planet != null)
            {
                return Ok(planet);
            }
            return NotFound();
        }

        [Route("getall")]
        [HttpGet]
        public Task<List<Planet>> GetAll()
        {
            return _context.Planets.ToListAsync();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            Planet planet = new Planet();
            var lastPlanet = _context.Planets.OrderByDescending(p => p.Id).FirstOrDefault();
            if (lastPlanet == null)
            {
                planet.Id = 1;
            }
            else
            {
                planet.Id = lastPlanet.Id + 1;
            }

            _context.Planets.Add(planet);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
