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
        /// <param name="user">Тело пользователя</param>
        /// <returns></returns>
        [HttpPost("current")]
        public IActionResult GetUser(User user)
        {
            return Ok(user);
        }
        
        /// <summary>
        /// Изменить данные пользователя по Id
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        [HttpPut("{id}", Name = "Put")]
        public IActionResult PutUser(User user)
        {
            return Ok(user);
        }
        
        /// <summary>
        /// Удалить пользователя по Id
        /// </summary>
        /// <param name="shortUser"></param>
        /// <returns></returns>
        [HttpDelete("{id}", Name = "Delete")]
        public IActionResult DeleteUser(ShortUserDto shortUser)
        {
            return Ok(shortUser);
        }
    }
}