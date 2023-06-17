using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController:ControllerBase
    {
        private readonly Dontnet10Assignment1Context _context;

        public PatientController(Dontnet10Assignment1Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> patientdata(int id)
        {
            try
            {
                var results = _context.Patientreports.FromSqlRaw($"exec query2 @pi={id}");
                return Ok(results);
            }
            catch (Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }

    }
}


