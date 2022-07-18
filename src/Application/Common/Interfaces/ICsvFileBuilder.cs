using MechanicApp.Application.TodoLists.Queries.ExportTodos;

namespace MechanicApp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
