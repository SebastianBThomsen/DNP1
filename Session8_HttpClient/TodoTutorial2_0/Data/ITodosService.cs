using System.Collections.Generic;
using System.Threading.Tasks;
using TodoTutorial2_0.Models;

namespace TodoTutorial2_0.Data
{
    public interface ITodosService
    {
        Task<IList<Todo>> GetTodosAsync();
        Task AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task UpdateAsync(Todo todo);
        Todo Get(int id);
    }
}