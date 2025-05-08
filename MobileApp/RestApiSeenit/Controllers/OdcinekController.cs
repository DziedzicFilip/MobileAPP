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
    public class OdcinekController : ControllerBase
    {
        private readonly FilmyContext _context;

        public OdcinekController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Odcinek
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OdcinekForView>>> GetOdcineks()
        {
          if (_context.Odcineks == null)
          {
              return NotFound();
          }
            return (await _context.Odcineks.ToListAsync())
              .Select(cli => (OdcinekForView)cli)
              .ToList();
        }

        // GET: api/Odcinek/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OdcinekForView>> GetOdcinek(int id)
        {
          if (_context.Odcineks == null)
          {
              return NotFound();
          }
            var odcinek = await _context.Odcineks.FindAsync(id);

            if (odcinek == null)
            {
                return NotFound();
            }

            return (OdcinekForView)odcinek;
        }

        // PUT: api/Odcinek/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOdcinek(int id, OdcinekForView odcinek)
        {
            if (id != odcinek.Id)
            {
                return BadRequest();
            }
            Odcinek odcinekToChange = odcinek;
            _context.Entry(odcinekToChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdcinekExists(id))
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

        // POST: api/Odcinek
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OdcinekForView>> PostOdcinek(OdcinekForView odcinek)
        {
          if (_context.Odcineks == null)
          {
              return Problem("Entity set 'FilmyContext.Odcineks'  is null.");
          }
            Odcinek odcinekToChange = odcinek;
            _context.Odcineks.Add(odcinekToChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOdcinek", new { id = odcinek.Id }, odcinek);
        }

        // DELETE: api/Odcinek/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOdcinek(int id)
        {
            if (_context.Odcineks == null)
            {
                return NotFound();
            }
            var odcinek = await _context.Odcineks.FindAsync(id);
            if (odcinek == null)
            {
                return NotFound();
            }

            _context.Odcineks.Remove(odcinek);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OdcinekExists(int id)
        {
            return (_context.Odcineks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
