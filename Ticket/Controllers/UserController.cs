using Microsoft.AspNetCore.Mvc;
using UserDTO;
using UserModel;
using UserService;

namespace UserController
{
    [ApiController]
    [Route("api/user")]
    public class UserControllers : ControllerBase
    {
        private readonly UserServices _userService;

        public UserControllers(UserServices userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]
        public IEnumerable<MUser> CreateUser([FromBody] IUser userData)
        {
            var createdUser = _userService.CreateUser(userData);
            return createdUser;
        }


        [HttpGet]
        public ActionResult<IEnumerable<MUser>> GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

    }
}
