namespace MAUIToDoApp.ViewModel;

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMauiLibrary.HelperClasses;
using WpfMauiLibrary.Models;
using WpfMauiLibrary.Services.DataAccess;

public partial class ThousendTasksPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<ToDoTask> openTasks = [];
    [ObservableProperty] private ObservableCollection<ToDoTask> closedTasks = [];
    private readonly ToDoTaskDbAccess dbAccess = new(Constants.DbMaui1000TasksFullPath);

    [RelayCommand]
    public void CreateThousendTasks()
    {
        for (var i = 0; i < 1000; i++)
        {
            var task = new ToDoTask($"Task number {i}");
            this.dbAccess.InsertOne(task);
        }
    }

    [RelayCommand]
    public void LoadThousendTasks() => this.OpenTasks = new(this.dbAccess.GetAll());

    [RelayCommand]
    public void DeleteThousendTasks()
    {
        for (var i = 0; i < 1000; i++)
        {
            this.dbAccess.DeleteOne(i + 1);
            this.OpenTasks.RemoveAt(i);
        }
    }
}
