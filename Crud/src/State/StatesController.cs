using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crud.Data;

namespace Crud.src.State
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : Controller
    {
        private readonly CrudDbContext _context;

        public StatesController(CrudDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetStates()
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStates(Guid id)
        {
            try
            {
                var result = await _context.States.FindAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostState([FromBody] StateEntity state)
        {
            try
            {
                _context.States.Add(state);
                await _context.SaveChangesAsync();
                return Ok(state);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutState([FromBody] StateEntity state)
        {
            try
            {
                _context.States.Update(state);
                await _context.SaveChangesAsync();
                return Ok(state);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteState(Guid id)
        {
            try
            {
                var state = await _context.States.FindAsync(id);
                if (state == null)
                {
                    return NotFound();
                }
                _context.States.Remove(state);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
