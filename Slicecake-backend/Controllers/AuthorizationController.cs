using Domain.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Note.Domain;

namespace Slicecake_backend.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IUserRepository _userRep;
        public AuthorizationController(IUserRepository userRep)
        {
            _userRep = userRep;
        }
        // POST: api/Authorization/Login
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="value">Форма авторизации</param>
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] ShortUserDto user)
        {
            var loginResponse = await _userRep.Login(user);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { message = "Incorrect Password of Username" });
            }

            return Ok(loginResponse);
        }
        // POST: api/Authorization/Register
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="value">Форма регистрации пользователя</param>
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var register = _userRep.Register(user);
            if (register == null)
            {
                return BadRequest(new {message = "Error"});
            }

            return Ok(register);
        }
    }
}
