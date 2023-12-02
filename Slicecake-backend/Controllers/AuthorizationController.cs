using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Slicecake_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        // POST: api/Authorization/Login
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="value">Форма авторизации</param>
        [HttpPost("Login")]
        public void Login([FromBody] string value)
        {
            
        }
        // POST: api/Authorization/Register
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="value">Форма регистрации пользователя</param>
        [HttpPost("Register")]
        public void Register([FromBody] string value)
        {
            
        }
    }
}
