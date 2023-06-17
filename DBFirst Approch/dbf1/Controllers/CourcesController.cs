using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dbf1.Models;

namespace dbf1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourcesController : ControllerBase
    {
        private readonly MyPracticeContext _context;

        public CourcesController(MyPracticeContext context)
        {
            _context = context;
        }

        // GET: api/Cources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cource>>> GetCources()
        {
          if (_context.Cources == null)
          {
              return NotFound();
          }
            return await _context.Cources.ToListAsync();
        }

        // GET: api/Cources/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cource>> GetCource(int id)
        {
          if (_context.Cources == null)
          {
              return NotFound();
          }
            var cource = await _context.Cources.FindAsync(id);

            if (cource == null)
            {
                return NotFound();
            }

            return cource;
        }

        // PUT: api/Cources/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCource(int id, Cource cource)
        {
            if (id != cource.CourceId)
            {
                return BadRequest();
            }

            _context.Entry(cource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourceExists(id))
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

        // POST: api/Cources
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cource>> PostCource(Cource cource)
        {
          if (_context.Cources == null)
          {
              return Problem("Entity set 'MyPracticeContext.Cources'  is null.");
          }
            _context.Cources.Add(cource);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CourceExists(cource.CourceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCource", new { id = cource.CourceId }, cource);
        }

        // DELETE: api/Cources/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCource(int id)
        {
            if (_context.Cources == null)
            {
                return NotFound();
            }
            var cource = await _context.Cources.FindAsync(id);
            if (cource == null)
            {
                return NotFound();
            }

            _context.Cources.Remove(cource);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourceExists(int id)
        {
            return (_context.Cources?.Any(e => e.CourceId == id)).GetValueOrDefault();
        }
    }
}
