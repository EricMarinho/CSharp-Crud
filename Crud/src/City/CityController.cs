using Crud.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud.src.City
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private readonly CrudDbContext _context;

        public CityController(CrudDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            try
            {
                var result = await _context.States.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
