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
    public class ListaObserwowaneController : ControllerBase
    {
        private readonly FilmyContext _context;

        public ListaObserwowaneController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/ListaObserwowane
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListaObserwowaneForView>>> GetListaObserwowanes()
        {
          if (_context.ListaObserwowanes == null)
          {
              return NotFound();
          }
            return (await _context.ListaObserwowanes.ToListAsync())
              .Select(cli => (ListaObserwowaneForView)cli)
              .ToList();
        }

        // GET: api/ListaObserwowane/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListaObserwowaneForView>> GetListaObserwowane(int id)
        {
          if (_context.ListaObserwowanes == null)
          {
              return NotFound();
          }
            var listaObserwowane = await _context.ListaObserwowanes.FindAsync(id);

            if (listaObserwowane == null)
            {
                return NotFound();
            }

            return (ListaObserwowaneForView)listaObserwowane;
        }

        // PUT: api/ListaObserwowane/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListaObserwowane(int id, ListaObserwowaneForView listaObserwowane)
        {
            if (id != listaObserwowane.Id)
            {
                return BadRequest();
            }
            ListaObserwowane listaToChange = listaObserwowane;
            _context.Entry(listaToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListaObserwowaneExists(id))
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

        // POST: api/ListaObserwowane
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListaObserwowaneForView>> PostListaObserwowane(ListaObserwowaneForView listaObserwowane)
        {
          if (_context.ListaObserwowanes == null)
          {
              return Problem("Entity set 'FilmyContext.ListaObserwowanes'  is null.");
          }
            ListaObserwowane listaToChange = listaObserwowane;
            _context.ListaObserwowanes.Add(listaToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListaObserwowane", new { id = listaObserwowane.Id }, listaObserwowane);
        }

        // DELETE: api/ListaObserwowane/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListaObserwowane(int id)
        {
            if (_context.ListaObserwowanes == null)
            {
                return NotFound();
            }
            var listaObserwowane = await _context.ListaObserwowanes.FindAsync(id);
            if (listaObserwowane == null)
            {
                return NotFound();
            }

            _context.ListaObserwowanes.Remove(listaObserwowane);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListaObserwowaneExists(int id)
        {
            return (_context.ListaObserwowanes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
