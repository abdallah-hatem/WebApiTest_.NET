using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Model;
using WebApiTest.Services.UserService;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = _userService.GetAllUsers();

            if (users is null)
            {
                return NotFound("No users found");
            }

            return Ok(users);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = _userService.GetUser(id);

            if (user is null)
            {
                return NotFound("No user found");
            }

            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult<User>?> AddUser(User user)
        {
            var addedUser = _userService.AddUser(user);

            if (addedUser is null) return null;

            return Ok(addedUser);
        }
    }
}
