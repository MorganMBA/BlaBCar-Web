using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlaBCar.Models;
using BlaBCar.Data;
using Microsoft.AspNetCore.Authorization;

namespace BlaBCar.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrajetController : ControllerBase
    {
        private readonly BlaBCarContext _context;

        public TrajetController(BlaBCarContext context)
        {
            _context = context;
        }

        // GET: api/Trajet
        [HttpGet]
        public async Task<IActionResult> GetTrajets()
        {
            var trajets = await _context.Trajets.ToListAsync();

            return Ok(trajets);
        }

        // GET: api/Trajet/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrajet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var trajet = await _context.Trajets.FindAsync(id);

            if (trajet == null)
            {
                return NotFound();
            }

            return Ok(trajet);
        }

        // PUT: api/Trajet/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrajet([FromRoute] long id, [FromBody] Trajet trajet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trajet.Id)
            {
                return BadRequest();
            }

            _context.Entry(trajet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrajetExists(id))
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

        // POST: api/Trajet
        [HttpPost]
        public async Task<IActionResult> PostTrajet([FromBody] Trajet trajet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Trajets.Add(trajet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrajet", new { id = trajet.Id }, trajet);
        }

        // DELETE: api/Trajet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrajet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var trajet = await _context.Trajets.FindAsync(id);
            if (trajet == null)
            {
                return NotFound();
            }

            _context.Trajets.Remove(trajet);
            await _context.SaveChangesAsync();

            return Ok(trajet);
        }

        private bool TrajetExists(long id)
        {
            return _context.Trajets.Any(e => e.Id == id);
        }
    }
}