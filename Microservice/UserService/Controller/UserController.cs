using Microsoft.AspNetCore.Mvc;
using UserService.Dto;
using UserService.Service;

namespace UserService.Controller
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser(UserDto userDto)
        {
            var newUser = _userService.CreateUser(userDto);
            return Ok();
        }
    }
}
