using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApiSeenit.ForView;
using RestApiSeenit.Helpers;
using RestApiSeenit.Models;
using RestApiSeenit.Models.Contexts;

namespace RestApiSeenit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly FilmyContext _context;

        public FilmController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Film
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmForView>>> GetFilms()
        {
          if (_context.Films == null)
          {
              return NotFound();
          }
            return (await _context.Films
                .Include(cli => cli.Rodzaj)
                .ToListAsync())
                .Select(cli => (FilmForView)cli)
                .ToList();
        }

        // GET: api/Film/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmForView>> GetFilm(int id)
        {
          if (_context.Films == null)
          {
              return NotFound();
          }
            var film = await _context.Films
                .Include(film => film.Rodzaj)
                .FirstOrDefaultAsync(film => film.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return (FilmForView)film;
        }

        // PUT: api/Film/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, FilmForView film)
        {
            if (id != film.Id)
            {
                return BadRequest();
            }
            var fil = await _context.Films.FindAsync(id);
            fil.CopyProperties(film);
            _context.Entry(fil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(id))
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

        // POST: api/Film
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmForView>> PostFilm(FilmForView film)
        {
          if (_context.Films == null)
          {
              return Problem("Entity set 'FilmyContext.Films'  is null.");
          }
            _context.Films.Add(film);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FilmExists(film.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(film);
        }
        

        // DELETE: api/Film/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilm(int id)
        {
            if (_context.Films == null)
            {
                return NotFound();
            }
            var film = await _context.Films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }

            _context.Films.Remove(film);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmExists(int id)
        {
            return (_context.Films?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
