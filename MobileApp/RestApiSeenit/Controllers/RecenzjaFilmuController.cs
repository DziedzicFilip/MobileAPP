using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApiSeenit.ForView;
using RestApiSeenit.Models;
using RestApiSeenit.Models.Contexts;

namespace RestApiSeenit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecenzjaFilmuController : ControllerBase
    {
        private readonly FilmyContext _context;

        public RecenzjaFilmuController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/RecenzjaFilmu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecenzjaFilmuForView>>> GetRecenzjaFilmus()
        {
          if (_context.RecenzjaFilmus == null)
          {
              return NotFound();
          }
            return (await _context.RecenzjaFilmus.ToListAsync())
              .Select(cli => (RecenzjaFilmuForView)cli)
              .ToList();
        }

        // GET: api/RecenzjaFilmu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecenzjaFilmuForView>> GetRecenzjaFilmu(int id)
        {
          if (_context.RecenzjaFilmus == null)
          {
              return NotFound();
          }
            var recenzjaFilmu = await _context.RecenzjaFilmus.FindAsync(id);

            if (recenzjaFilmu == null)
            {
                return NotFound();
            }

            return (RecenzjaFilmuForView)recenzjaFilmu;
        }

        // PUT: api/RecenzjaFilmu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecenzjaFilmu(int id, RecenzjaFilmuForView recenzjaFilmu)
        {
            if (id != recenzjaFilmu.Id)
            {
                return BadRequest();
            }
            RecenzjaFilmu recenzjaToChange = recenzjaFilmu;
            _context.Entry(recenzjaToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecenzjaFilmuExists(id))
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

        // POST: api/RecenzjaFilmu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecenzjaFilmuForView>> PostRecenzjaFilmu(RecenzjaFilmuForView recenzjaFilmu)
        {
          if (_context.RecenzjaFilmus == null)
          {
              return Problem("Entity set 'FilmyContext.RecenzjaFilmus'  is null.");
          }
            RecenzjaFilmu recenzjaToChange = recenzjaFilmu;
            _context.RecenzjaFilmus.Add(recenzjaToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecenzjaFilmu", new { id = recenzjaFilmu.Id }, recenzjaFilmu);
        }

        // DELETE: api/RecenzjaFilmu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecenzjaFilmu(int id)
        {
            if (_context.RecenzjaFilmus == null)
            {
                return NotFound();
            }
            var recenzjaFilmu = await _context.RecenzjaFilmus.FindAsync(id);
            if (recenzjaFilmu == null)
            {
                return NotFound();
            }

            _context.RecenzjaFilmus.Remove(recenzjaFilmu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecenzjaFilmuExists(int id)
        {
            return (_context.RecenzjaFilmus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
