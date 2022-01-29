using BaseArchitecture.Application.Common.Mappings;
using BaseArchitecture.Domain.Entities;

namespace BaseArchitecture.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
