using BaseArchitecture.Application.TodoLists.Queries.ExportTodos;

namespace BaseArchitecture.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
