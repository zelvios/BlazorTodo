namespace BlazorTodo.Components.Models;

public enum TodoStatus
{
    Scheduled,
    Completed
}

public class TodoItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public TodoStatus Status { get; set; } = TodoStatus.Scheduled;
}