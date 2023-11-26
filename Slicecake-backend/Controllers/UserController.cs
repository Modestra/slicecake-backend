using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Note.Domain;

namespace Slicecake_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        [HttpPost("current")]
        public IActionResult GetUser(User user)
        {
            return Ok(user);
        }
        /// <summary>
        /// Изменить данные пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        [HttpPost("post")]
        public IActionResult PostUser(User user)
        {
            return Ok(user);
        }
    }
}