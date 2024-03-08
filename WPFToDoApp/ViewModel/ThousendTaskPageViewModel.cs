namespace WPFToDoApp.ViewModel;

using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMauiLibrary.Models;

public partial class ThousendTaskPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<ToDoTask> openTasks = [];
    [ObservableProperty] private string? elapsedTime;

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
        this.ElapsedTime = $"{stopwatch.ElapsedMilliseconds}";
        stopwatch.Reset();
    }

    [RelayCommand]
    public void EmptyList() => this.OpenTasks.Clear();
}
