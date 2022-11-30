using TestApp.Application.Common.Mappings;
using TestApp.Domain.Entities;

namespace TestApp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
