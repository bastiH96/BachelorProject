namespace WPFToDoApp.ViewModel;

using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMauiLibrary.HelperClasses;
using WpfMauiLibrary.Models;
using WpfMauiLibrary.Services.DataAccess;

public partial class ThousendTaskPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<ToDoTask> openTasks = [];
    [ObservableProperty] private string elapsedTime;
    private readonly ToDoTaskDbAccess dbAccess = new(Constants.DbMaui1000TasksFullPath);

    [RelayCommand]
    public void CreateThousendTasksForDb()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = 0; i < 1000; i++)
        {
            var task = new ToDoTask($"Task number {i}");
            this.dbAccess.InsertOne(task);
        }
        stopwatch.Stop();
        this.ElapsedTime = stopwatch.ElapsedMilliseconds.ToString();
        stopwatch.Reset();
    }

    [RelayCommand]
    public void LoadThousendTasksFromDb()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        this.OpenTasks = new(this.dbAccess.GetAll());

        stopwatch.Stop();
        this.ElapsedTime = stopwatch.ElapsedMilliseconds.ToString();
        stopwatch.Reset();
    }

    [RelayCommand]
    public void CreateThousendTasks()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (var i = 0; i < 1000; i++)
        {
            var task = new ToDoTask($"Task number {i}");
            this.OpenTasks.Add(task);
        }

        stopwatch.Stop();
        this.ElapsedTime = stopwatch.ElapsedMilliseconds.ToString();
        stopwatch.Reset();
    }

    [RelayCommand]
    public void EmptyList() => this.OpenTasks.Clear();
}
