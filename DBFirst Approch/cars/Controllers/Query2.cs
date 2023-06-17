using cars.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace cars.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Query2 : ControllerBase
    {
        private readonly MyPracticeContext cont;

        public Query2(MyPracticeContext cont)
        {
            this.cont = cont;
        }
        [HttpGet]
        public async Task<IActionResult> data()
        {
            try
            {
                var result = cont.Honda.FromSqlRaw($"exec data");
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpGet]
        [Route("report")]
        public async Task<IActionResult> data1()
        {
            try
            {
                var result = cont.Honda.FromSqlRaw($"exec data");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
