using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Slicecake_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        /// <summary>
        /// Создает карточку по модели
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        public IEnumerable<string> CreateNote()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Получить карточку через систему поиска
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{name}", Name = "Get")]
        public string Get(string name)
        {
            return "value";
        }
    }
}
