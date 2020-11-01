using BookStore.Dal.ViewModel;
using BookStore.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var users = await _userRepository.GetTopTen();
        //    return Ok(users);
        //}

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto user)
        {
            var newUser = await _userRepository.AddUser(user);
            return Ok(newUser);
        }
        [HttpPost]
        public async Task<IActionResult> LogIn([FromBody] UserLoginDto user)
        {
            var User = await _userRepository.LogInUser(user);
            return Ok(User);
        }
    }

}
