using TestApp.Application.TodoLists.Queries.ExportTodos;

namespace TestApp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
