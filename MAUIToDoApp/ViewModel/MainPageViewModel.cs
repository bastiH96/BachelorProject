namespace MAUIToDoApp.ViewModel;

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMauiLibrary.HelperClasses;
using WpfMauiLibrary.Models;
using WpfMauiLibrary.Services.DataAccess;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string content;
    [ObservableProperty] private ObservableCollection<ToDoTask> openTasks = [];
    [ObservableProperty] private ObservableCollection<ToDoTask> closedTasks = [];

    private readonly ToDoTaskDbAccess db = new(Constants.DbMauiFullPath);

    public MainPageViewModel() => this.FillTaskLists();

    [RelayCommand]
    public void AddNewTask()
    {
        var task = new ToDoTask(this.Content);
        this.db.InsertOne(task);
        this.OpenTasks.Add(task);
        this.Content = string.Empty;
    }

    [RelayCommand]
    public void ChangeStatus(object obj)
    {
        if (obj is ToDoTask toDoTask)
        {
            this.db.UpdateOne(toDoTask);
            if (this.OpenTasks.Contains(toDoTask))
            {
                toDoTask.IsCompleted = true;
                this.OpenTasks.Remove(toDoTask);
                this.ClosedTasks.Add(toDoTask);
            }
            else
            {
                toDoTask.IsCompleted = false;
                this.ClosedTasks.Remove(toDoTask);
                this.OpenTasks.Add(toDoTask);
            }
        }
    }

    [RelayCommand]
    public void DeleteTask(object obj)
    {
        if (obj is ToDoTask toDoTask)
        {
            this.db.DeleteOne(toDoTask.Id);
            if (!this.OpenTasks.Remove(toDoTask))
            {
                this.ClosedTasks.Remove(toDoTask);
            }
        }
    }

    [RelayCommand]
    public void EditTask(object obj)
    {
        if (obj is ToDoTask toDoTask)
        {
            if (toDoTask.IsEntryFieldReadOnly)
            {
                toDoTask.IsEntryFieldReadOnly = false;
            }
            else
            {
                this.db.UpdateOne(toDoTask);
                toDoTask.IsEntryFieldReadOnly = true;
            }
            if (toDoTask.IsCompleted)
            {
                var index = this.ClosedTasks.IndexOf(this.ClosedTasks.Single(x => x.Id == toDoTask.Id));
                this.ClosedTasks[index] = toDoTask;
            }
            else
            {
                var index = this.OpenTasks.IndexOf(this.OpenTasks.Single(x => x.Id == toDoTask.Id));
                this.OpenTasks[index] = toDoTask;
            }
        }
    }

    private void FillTaskLists()
    {
        var allTasks = this.db.GetAll();
        foreach (var task in allTasks)
        {
            task.IsEntryFieldReadOnly = true;
        }
        this.OpenTasks = new(allTasks.Where(x => x.IsCompleted == false));
        this.ClosedTasks = new(allTasks.Where(x => x.IsCompleted));
    }
}
