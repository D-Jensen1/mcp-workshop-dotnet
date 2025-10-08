using McpTodoServer.ContainerApp.Data;
using McpTodoServer.ContainerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace McpTodoServer.ContainerApp.Services;

public class TodoService
{
    private readonly TodoDbContext _dbContext;

    public TodoService(TodoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TodoItem> CreateAsync(string text)
    {
        var item = new TodoItem { Text = text, IsCompleted = false };
        _dbContext.TodoItems.Add(item);
        await _dbContext.SaveChangesAsync();
        return item;
    }

    public async Task<List<TodoItem>> ListAsync()
    {
        return await _dbContext.TodoItems.AsNoTracking().ToListAsync();
    }

    public async Task<TodoItem?> UpdateAsync(int id, string newText)
    {
        var item = await _dbContext.TodoItems.FindAsync(id);
        if (item == null) return null;
        item.Text = newText;
        await _dbContext.SaveChangesAsync();
        return item;
    }

    public async Task<TodoItem?> CompleteAsync(int id)
    {
        var item = await _dbContext.TodoItems.FindAsync(id);
        if (item == null) return null;
        item.IsCompleted = true;
        await _dbContext.SaveChangesAsync();
        return item;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var item = await _dbContext.TodoItems.FindAsync(id);
        if (item == null) return false;
        _dbContext.TodoItems.Remove(item);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}