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
    public class ListaObejrzaneController : ControllerBase
    {
        private readonly FilmyContext _context;

        public ListaObejrzaneController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/ListaObejrzane
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListaObejrzaneForView>>> GetListaObejrzanes()
        {
          if (_context.ListaObejrzanes == null)
          {
              return NotFound();
          }
            return (await _context.ListaObejrzanes.ToListAsync()).Select(item=>(ListaObejrzaneForView)item).ToList();
        }

        // GET: api/ListaObejrzane/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListaObejrzaneForView>> GetListaObejrzane(int id)
        {
          if (_context.ListaObejrzanes == null)
          {
              return NotFound();
          }
            var listaObejrzane = await _context.ListaObejrzanes.FindAsync(id);

            if (listaObejrzane == null)
            {
                return NotFound();
            }

            return (ListaObejrzaneForView)listaObejrzane;
        }

        // PUT: api/ListaObejrzane/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListaObejrzane(int id, ListaObejrzaneForView listaObejrzane)
        {
            if (id != listaObejrzane.Id)
            {
                return BadRequest();
            }
            ListaObejrzane listaToChange = listaObejrzane;
            _context.Entry(listaToChange).State = EntityState.Modified;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListaObejrzaneExists(id))
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

        // POST: api/ListaObejrzane
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListaObejrzaneForView>> PostListaObejrzane(ListaObejrzaneForView listaObejrzane)
        {
          if (_context.ListaObejrzanes == null)
          {
              return Problem("Entity set 'FilmyContext.ListaObejrzanes'  is null.");
          }
            ListaObejrzane listaToChange = listaObejrzane;
            _context.ListaObejrzanes.Add(listaToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListaObejrzane", new { id = listaObejrzane.Id }, listaObejrzane);
        }

        // DELETE: api/ListaObejrzane/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListaObejrzane(int id)
        {
            if (_context.ListaObejrzanes == null)
            {
                return NotFound();
            }
            var listaObejrzane = await _context.ListaObejrzanes.FindAsync(id);
            if (listaObejrzane == null)
            {
                return NotFound();
            }

            _context.ListaObejrzanes.Remove(listaObejrzane);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListaObejrzaneExists(int id)
        {
            return (_context.ListaObejrzanes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
