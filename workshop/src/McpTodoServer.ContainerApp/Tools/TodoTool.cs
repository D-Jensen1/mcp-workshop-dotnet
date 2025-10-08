using McpTodoServer.ContainerApp.Models;
using McpTodoServer.ContainerApp.Services;
using ModelContextProtocol.Server;
using System.ComponentModel;

namespace McpTodoServer.ContainerApp.Tools;

[McpServerToolType]
public class TodoTool
{
    private readonly TodoService _todoService;

    public TodoTool(TodoService todoService)
    {
        _todoService = todoService;
    }

    [McpServerTool(Name = "add_todo_item", Title = "Add a to-do item")]
    [Description("Adds a to-do item to database.")]

    public async Task<TodoItem> CreateAsync(string text)
        => await _todoService.CreateAsync(text);

    [McpServerTool(Name = "get_todo_items", Title = "Get a list of to-do items")]
    [Description("Gets a list of to-do items from database.")]
    public async Task<List<TodoItem>> ListAsync()
        => await _todoService.ListAsync();

    [McpServerTool(Name = "update_todo_item", Title = "Update a to-do item")]
    [Description("Updates a to-do item in the database.")]

    public async Task<TodoItem?> UpdateAsync(int id, string newText)
        => await _todoService.UpdateAsync(id, newText);

    [McpServerTool(Name = "complete_todo_item", Title = "Complete a to-do item")]
    [Description("Completes a to-do item in the database.")]

    public async Task<TodoItem?> CompleteAsync(int id)
        => await _todoService.CompleteAsync(id);

    [McpServerTool(Name = "delete_todo_item", Title = "Delete a to-do item")]
    [Description("Deletes a to-do item from the database.")]
    
    public async Task<bool> DeleteAsync(int id)
            => await _todoService.DeleteAsync(id);
}