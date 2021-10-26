using System.Collections.Generic;
using System.Threading.Tasks;
using TodoTutorial2_0.Models;

namespace TodoTutorial2_0.Data
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