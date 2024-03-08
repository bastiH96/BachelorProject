namespace MAUIToDoApp.ViewModel;

using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIToDoApp.View;
using WpfMauiLibrary.Models;

public partial class ChangePageViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty] private string? elapsedTime;
    [ObservableProperty] private ObservableCollection<ToDoTask> openTasks = [];
    [ObservableProperty] private ObservableCollection<ToDoTask> closedTasks = [];
    private readonly Stopwatch stopwatch = new();

    [RelayCommand]
    public async Task ChangePage()
    {
        this.stopwatch.Start();
        await Shell.Current.GoToAsync(nameof(SecondPageView));
        IDictionary<string, object> queryData = new Dictionary<string, object>()
        {
            {"stopwatch", "data" }
        };
        await Shell.Current.GoToAsync(nameof(SecondPageView), queryData);
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        this.stopwatch.Stop();
        this.ElapsedTime = $"{this.stopwatch.ElapsedMilliseconds}";
    }
}
