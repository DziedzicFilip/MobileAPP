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
    public class RecenzjaOdcinkaController : ControllerBase
    {
        private readonly FilmyContext _context;

        public RecenzjaOdcinkaController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/RecenzjaOdcinka
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecenzjaOdcinkaForView>>> GetRecenzjaOdcinkas()
        {
          if (_context.RecenzjaOdcinkas == null)
          {
              return NotFound();
          }
            return (await _context.RecenzjaOdcinkas.ToListAsync())
                .Select(cli => (RecenzjaOdcinkaForView)cli)
                .ToList();
        }

        // GET: api/RecenzjaOdcinka/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecenzjaOdcinkaForView>> GetRecenzjaOdcinka(int id)
        {
          if (_context.RecenzjaOdcinkas == null)
          {
              return NotFound();
          }
            var recenzjaOdcinka = await _context.RecenzjaOdcinkas.FindAsync(id);

            if (recenzjaOdcinka == null)
            {
                return NotFound();
            }

            return (RecenzjaOdcinkaForView)recenzjaOdcinka;
        }

        // PUT: api/RecenzjaOdcinka/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecenzjaOdcinka(int id, RecenzjaOdcinkaForView recenzjaOdcinka)
        {
            if (id != recenzjaOdcinka.Id)
            {
                return BadRequest();
            }
            RecenzjaOdcinka recenzjaToChange = recenzjaOdcinka;
            _context.Entry(recenzjaToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecenzjaOdcinkaExists(id))
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

        // POST: api/RecenzjaOdcinka
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecenzjaOdcinkaForView>> PostRecenzjaOdcinka(RecenzjaOdcinkaForView recenzjaOdcinka)
        {
          if (_context.RecenzjaOdcinkas == null)
          {
              return Problem("Entity set 'FilmyContext.RecenzjaOdcinkas'  is null.");
          }
            RecenzjaOdcinka recenzjaToChange = recenzjaOdcinka;
            _context.RecenzjaOdcinkas.Add(recenzjaToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecenzjaOdcinka", new { id = recenzjaOdcinka.Id }, recenzjaOdcinka);
        }

        // DELETE: api/RecenzjaOdcinka/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecenzjaOdcinka(int id)
        {
            if (_context.RecenzjaOdcinkas == null)
            {
                return NotFound();
            }
            var recenzjaOdcinka = await _context.RecenzjaOdcinkas.FindAsync(id);
            if (recenzjaOdcinka == null)
            {
                return NotFound();
            }

            _context.RecenzjaOdcinkas.Remove(recenzjaOdcinka);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecenzjaOdcinkaExists(int id)
        {
            return (_context.RecenzjaOdcinkas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
