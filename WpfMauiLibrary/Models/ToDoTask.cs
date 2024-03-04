namespace WpfMauiLibrary.Models;

using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

[SQLite.Table("Tasks")]
public class ToDoTask
{
    [AutoIncrement, PrimaryKey]
    public int Id { get; set; }
    public string? Content { get; set; }
    public bool IsCompleted { get; set; }
    [Ignore]
    public bool IsEntryFieldReadOnly { get; set; }

    public ToDoTask()
    {

    }

    public ToDoTask(string content)
    {
        this.Content = content;
        this.IsEntryFieldReadOnly = true;
    }
}
