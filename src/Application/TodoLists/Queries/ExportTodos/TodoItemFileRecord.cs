using FartakCA.Application.Common.Mappings;
using FartakCA.Domain.Entities;

namespace FartakCA.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
