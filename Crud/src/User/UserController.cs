using Crud.src.User.dto;
using Microsoft.AspNetCore.Mvc;

namespace Crud.src.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<UserEntity> result = await _userService.GetUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            UserEntity? result = await _userService.GetUser(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] CreateUserDto user)
        {
            await _userService.PostUser(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] CreateUserDto user)
        {
            await _userService.PutUser(id, user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _userService.DeleteUser(id);
            return Ok();
        }
    }
}
