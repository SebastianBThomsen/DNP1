using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using TodosWebAPI.Data;
using TodosWebAPI.Models;


namespace TodosWebAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodosService service;
        
        private IList<Todo> todos;
        private IList<Todo> todosToShow;

        public TodosController(ITodosService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? isCompleted, [FromQuery] int? userId)
        {
            try
            {
                todos = service.GetTodos();
                
                ExecuteFilter(isCompleted, userId);
                return Ok(todosToShow);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Todo>> AddTodo([FromBody] Todo todo)
        {
            try
            {
                Todo added = await service.AddTodoAsync(todo);
                return Created($"/{added.TodoId}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        /*
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteTodo([FromRoute] int id)
        {
            try
            {
                service.RemoveTodo(id);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        */
        
        [HttpPatch]
        
        

        private void ExecuteFilter(bool? filterByIsCompleted, int? filterById)
        {
            todosToShow = todos.Where(t =>
                (filterById != null && t.UserId == filterById || filterById == null) &&
                (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
        }
    }
}