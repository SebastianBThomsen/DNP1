using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebAPI.Models;

namespace TodosWebAPI.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        Task<Todo> AddTodoAsync(Todo todo);
        void RemoveTodo(int todoId);
        void Update(Todo todo);
        Todo Get(int id);
    }
}