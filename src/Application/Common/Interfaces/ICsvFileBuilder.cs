using FartakCA.Application.TodoLists.Queries.ExportTodos;

namespace FartakCA.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
