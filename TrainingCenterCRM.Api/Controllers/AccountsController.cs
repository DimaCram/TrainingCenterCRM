using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;

namespace TrainingCenterCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserDto userLogin)
        {
            if (await _userService.CheckPassword(userLogin.Email, userLogin.Password))
            {
                var token = await _userService.GetToken(userLogin.Email);
                var userRoles = await _userService.GetUserRole(userLogin.Email);

                return Ok(new { token, userRoles });
            }
            return BadRequest("Incorrect login or password");
        }
    }
}