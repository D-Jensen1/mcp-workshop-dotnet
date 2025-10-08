using McpTodoServer.ContainerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace McpTodoServer.ContainerApp.Data;

public class TodoDbContext : DbContext
{
    public DbSet<TodoItem> TodoItems { get; set; }

    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>().HasKey(t => t.ID);
        base.OnModelCreating(modelBuilder);
    }
}