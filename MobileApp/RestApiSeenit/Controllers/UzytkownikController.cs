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
    public class UzytkownikController : ControllerBase
    {
        private readonly FilmyContext _context;

        public UzytkownikController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Uzytkownik
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UzytkownikForView>>> GetUzytkowniks()
        {
          if (_context.Uzytkowniks == null)
          {
              return NotFound();
          }
            return (await _context.Uzytkowniks.ToListAsync())
                .Select(cli => (UzytkownikForView)cli)
                .ToList();
        }

        // GET: api/Uzytkownik/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UzytkownikForView>> GetUzytkownik(int id)
        {
          if (_context.Uzytkowniks == null)
          {
              return NotFound();
          }
            var uzytkownik = await _context.Uzytkowniks.FindAsync(id);

            if (uzytkownik == null)
            {
                return NotFound();
            }

            return (UzytkownikForView)uzytkownik;
        }

        // PUT: api/Uzytkownik/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUzytkownik(int id, UzytkownikForView uzytkownik)
        {
            if (id != uzytkownik.Id)
            {
                return BadRequest();
            }
            Uzytkownik uzytkownikToChange = uzytkownik;
            _context.Entry(uzytkownikToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UzytkownikExists(id))
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

        // POST: api/Uzytkownik
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UzytkownikForView>> PostUzytkownik(UzytkownikForView uzytkownik)
        {
          if (_context.Uzytkowniks == null)
          {
              return Problem("Entity set 'FilmyContext.Uzytkowniks'  is null.");
          }
            Uzytkownik uzytkownikToChange = uzytkownik;
            _context.Uzytkowniks.Add(uzytkownikToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUzytkownik", new { id = uzytkownik.Id }, uzytkownik);
        }

        // DELETE: api/Uzytkownik/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUzytkownik(int id)
        {
            if (_context.Uzytkowniks == null)
            {
                return NotFound();
            }
            var uzytkownik = await _context.Uzytkowniks.FindAsync(id);
            if (uzytkownik == null)
            {
                return NotFound();
            }

            _context.Uzytkowniks.Remove(uzytkownik);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UzytkownikExists(int id)
        {
            return (_context.Uzytkowniks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
