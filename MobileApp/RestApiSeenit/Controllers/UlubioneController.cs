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
    public class UlubioneController : ControllerBase
    {
        private readonly FilmyContext _context;

        public UlubioneController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Ulubione
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UlubioneForView>>> GetUlubiones()
        {
          if (_context.Ulubiones == null)
          {
              return NotFound();
          }
            return (await _context.Ulubiones.ToListAsync())
              .Select(cli => (UlubioneForView)cli)
              .ToList();
        }

        // GET: api/Ulubione/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UlubioneForView>> GetUlubione(int id)
        {
          if (_context.Ulubiones == null)
          {
              return NotFound();
          }
            var ulubione = await _context.Ulubiones.FindAsync(id);

            if (ulubione == null)
            {
                return NotFound();
            }

            return (UlubioneForView)ulubione;
        }

        // PUT: api/Ulubione/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUlubione(int id, UlubioneForView ulubione)
        {
            if (id != ulubione.Id)
            {
                return BadRequest();
            }
            Ulubione ulubioneToChange = ulubione;
            _context.Entry(ulubioneToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlubioneExists(id))
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

        // POST: api/Ulubione
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UlubioneForView>> PostUlubione(UlubioneForView ulubione)
        {
          if (_context.Ulubiones == null)
          {
              return Problem("Entity set 'FilmyContext.Ulubiones'  is null.");
          }
            Ulubione ulubioneToChange = ulubione;
            _context.Ulubiones.Add(ulubioneToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUlubione", new { id = ulubione.Id }, ulubione);
        }

        // DELETE: api/Ulubione/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUlubione(int id)
        {
            if (_context.Ulubiones == null)
            {
                return NotFound();
            }
            var ulubione = await _context.Ulubiones.FindAsync(id);
            if (ulubione == null)
            {
                return NotFound();
            }

            _context.Ulubiones.Remove(ulubione);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UlubioneExists(int id)
        {
            return (_context.Ulubiones?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
