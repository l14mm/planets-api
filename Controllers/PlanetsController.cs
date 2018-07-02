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
        
        [HttpPost]
        public void Post([FromBody]Planet p)
        {
            if (ModelState.IsValid)
            {
                _context.Planets.Add(p);
                _context.SaveChanges();
            }
        }
    }
}
