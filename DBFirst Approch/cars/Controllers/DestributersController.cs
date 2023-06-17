using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cars.Models;

namespace cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestributersController : ControllerBase
    {
        private readonly MyPracticeContext _context;

        public DestributersController(MyPracticeContext context)
        {
            _context = context;
        }

        // GET: api/Destributers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destributer>>> GetDestributers()
        {
          if (_context.Destributers == null)
          {
              return NotFound();
          }
            return await _context.Destributers.ToListAsync();
        }

        // GET: api/Destributers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destributer>> GetDestributer(int id)
        {
          if (_context.Destributers == null)
          {
              return NotFound();
          }
            var destributer = await _context.Destributers.FindAsync(id);

            if (destributer == null)
            {
                return NotFound();
            }

            return destributer;
        }

        // PUT: api/Destributers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestributer(int id, Destributer destributer)
        {
            if (id != destributer.DestributerId)
            {
                return BadRequest();
            }

            _context.Entry(destributer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestributerExists(id))
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

        // POST: api/Destributers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destributer>> PostDestributer(Destributer destributer)
        {
          if (_context.Destributers == null)
          {
              return Problem("Entity set 'MyPracticeContext.Destributers'  is null.");
          }
            _context.Destributers.Add(destributer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DestributerExists(destributer.DestributerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDestributer", new { id = destributer.DestributerId }, destributer);
        }

        // DELETE: api/Destributers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestributer(int id)
        {
            if (_context.Destributers == null)
            {
                return NotFound();
            }
            var destributer = await _context.Destributers.FindAsync(id);
            if (destributer == null)
            {
                return NotFound();
            }

            _context.Destributers.Remove(destributer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestributerExists(int id)
        {
            return (_context.Destributers?.Any(e => e.DestributerId == id)).GetValueOrDefault();
        }
    }
}
