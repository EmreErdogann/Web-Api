using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Busines.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _todoService.GetAll();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var list = _todoService.GetById(id);
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Create(Todo todo)
        {

            _todoService.Add(todo);
            return Created(string.Empty, todo);
        }
        [HttpPut]
        public IActionResult Update(Todo todo)
        {
            _todoService.Update(todo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _todoService.GetById(id);
            _todoService.Remove(deleted);
            return NoContent();
        }

    }
}
