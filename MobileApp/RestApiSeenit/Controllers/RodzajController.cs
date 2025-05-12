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
    public class RodzajController : ControllerBase
    {
        private readonly FilmyContext _context;

        public RodzajController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Rodzaj
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RodzajForView>>> GetRodzajs()
        {
          if (_context.Rodzajs == null)
          {
              return NotFound();
          }
            return (await _context.Rodzajs.ToListAsync())
              .Select(cli => (RodzajForView)cli)
              .ToList();
        }

        // GET: api/Rodzaj/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RodzajForView>> GetRodzaj(int id)
        {
          if (_context.Rodzajs == null)
          {
              return NotFound();
          }
            var rodzaj = await _context.Rodzajs.FindAsync(id);

            if (rodzaj == null)
            {
                return NotFound();
            }

            return (RodzajForView)rodzaj;
        }

        // PUT: api/Rodzaj/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRodzaj(int id, RodzajForView rodzaj)
        {
            if (id != rodzaj.Id)
            {
                return BadRequest();
            }
            Rodzaj rodzajToChange = rodzaj;
            _context.Entry(rodzajToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RodzajExists(id))
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

        // POST: api/Rodzaj
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RodzajForView>> PostRodzaj(RodzajForView rodzaj)
        {
          if (_context.Rodzajs == null)
          {
              return Problem("Entity set 'FilmyContext.Rodzajs'  is null.");
          }
            Rodzaj rodzajToChange = rodzaj;
            _context.Rodzajs.Add(rodzajToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRodzaj", new { id = rodzaj.Id }, rodzaj);
        }

        // DELETE: api/Rodzaj/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRodzaj(int id)
        {
            if (_context.Rodzajs == null)
            {
                return NotFound();
            }
            var rodzaj = await _context.Rodzajs.FindAsync(id);
            if (rodzaj == null)
            {
                return NotFound();
            }

            _context.Rodzajs.Remove(rodzaj);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RodzajExists(int id)
        {
            return (_context.Rodzajs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
