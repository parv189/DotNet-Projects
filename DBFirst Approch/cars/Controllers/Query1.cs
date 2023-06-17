using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cars.Models;

namespace cars.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Query1 : ControllerBase
    {

        private readonly MyPracticeContext _context;

        public Query1(MyPracticeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> data()
        {
            try
            {
                var result = _context.Destributers.FromSqlRaw($"select * from destributer");
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
    }
}
