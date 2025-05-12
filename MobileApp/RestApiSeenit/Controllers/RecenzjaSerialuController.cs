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
    public class RecenzjaSerialuController : ControllerBase
    {
        private readonly FilmyContext _context;

        public RecenzjaSerialuController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/RecenzjaSerialu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecenzjaSerialuForView>>> GetRecenzjaSerialus()
        {
          if (_context.RecenzjaSerialus == null)
          {
              return NotFound();
          }
            return (await _context.RecenzjaSerialus.ToListAsync())
              .Select(cli => (RecenzjaSerialuForView)cli)
              .ToList();
        }

        // GET: api/RecenzjaSerialu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecenzjaSerialuForView>> GetRecenzjaSerialu(int id)
        {
          if (_context.RecenzjaSerialus == null)
          {
              return NotFound();
          }
            var recenzjaSerialu = await _context.RecenzjaSerialus.FindAsync(id);

            if (recenzjaSerialu == null)
            {
                return NotFound();
            }

            return (RecenzjaSerialuForView)recenzjaSerialu;
        }

        // PUT: api/RecenzjaSerialu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecenzjaSerialu(int id, RecenzjaSerialuForView recenzjaSerialu)
        {
            if (id != recenzjaSerialu.Id)
            {
                return BadRequest();
            }
            RecenzjaSerialu recenzjaToChange = recenzjaSerialu;
            _context.Entry(recenzjaToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecenzjaSerialuExists(id))
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

        // POST: api/RecenzjaSerialu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecenzjaSerialuForView>> PostRecenzjaSerialu(RecenzjaSerialuForView recenzjaSerialu)
        {
          if (_context.RecenzjaSerialus == null)
          {
              return Problem("Entity set 'FilmyContext.RecenzjaSerialus'  is null.");
          }
            RecenzjaSerialu recenzjaToChange = recenzjaSerialu;
            _context.RecenzjaSerialus.Add(recenzjaToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecenzjaSerialu", new { id = recenzjaSerialu.Id }, recenzjaSerialu);
        }

        // DELETE: api/RecenzjaSerialu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecenzjaSerialu(int id)
        {
            if (_context.RecenzjaSerialus == null)
            {
                return NotFound();
            }
            var recenzjaSerialu = await _context.RecenzjaSerialus.FindAsync(id);
            if (recenzjaSerialu == null)
            {
                return NotFound();
            }

            _context.RecenzjaSerialus.Remove(recenzjaSerialu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecenzjaSerialuExists(int id)
        {
            return (_context.RecenzjaSerialus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
