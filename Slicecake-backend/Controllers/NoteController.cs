using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Note.Domain;

namespace Slicecake_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        /// <summary>
        /// Получить все доступные карточки
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Notes> GetNotes()
        {
            List<Notes> notes = new List<Notes>();
            return notes;
        }
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
        /// <param name="name">Название карточки</param>
        /// <returns></returns>
        [HttpPost("{name}", Name = "Get")]
        public string Get(string name)
        {
            return "value";
        }
        /// <summary>
        /// Удаление выбранной карточки
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public string Delete(string name)
        {
            return name;
        }
    }
}
