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
    public class SerialController : ControllerBase
    {
        private readonly FilmyContext _context;

        public SerialController(FilmyContext context)
        {
            _context = context;
        }

        // GET: api/Serial
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SerialForView>>> GetSerials()
        {
          if (_context.Serials == null)
          {
              return NotFound();
          }
            return (await _context.Serials.Include(cli => cli.Rodzaj)
                .ToListAsync())
                .Select(cli => (SerialForView)cli)
                .ToList();
        }

        // GET: api/Serial/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SerialForView>> GetSerial(int id)
        {
          if (_context.Serials == null)
          {
              return NotFound();
          }
            var serial = await _context.Serials.FindAsync(id);

            if (serial == null)
            {
                return NotFound();
            }

            return (SerialForView)serial;
        }

        // PUT: api/Serial/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSerial(int id, SerialForView serial)
        {
            if (id != serial.Id)
            {
                return BadRequest();
            }
            var serialToChange = await _context.Serials.FindAsync(id);
            serialToChange.CopyProperties(serial);
            _context.Entry(serialToChange).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SerialExists(id))
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

        // POST: api/Serial
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SerialForView>> PostSerial(SerialForView serial)
        {
            if (_context.Serials == null)
            {
                return Problem("Entity set 'FilmyContext.Serials'  is null.");
            }
            _context.Serials.Add(serial);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SerialExists(serial.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(serial);
        }

        // DELETE: api/Serial/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSerial(int id)
        {
            if (_context.Serials == null)
            {
                return NotFound();
            }
            var serial = await _context.Serials.FindAsync(id);
            if (serial == null)
            {
                return NotFound();
            }

            _context.Serials.Remove(serial);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SerialExists(int id)
        {
            return (_context.Serials?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
