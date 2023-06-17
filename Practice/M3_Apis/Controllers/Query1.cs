using M3_Apis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace M3_Apis.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Query1:ControllerBase
    {
        protected readonly Module10CContext _context;

        public Query1(Module10CContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> data(int id)
        {
            try
            {
                var result = _context.Query1.FromSqlRaw($"exec query1 @id={id}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

    }
}
