namespace WPFToDoApp.ViewModel;

using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFToDoApp.View;

public partial class ChangePageViewModel : ObservableObject
{
    [ObservableProperty] private string elapsedTime;
    [ObservableProperty] private object? frameContent;

    public ChangePageViewModel()
    {
    }

    public ChangePageViewModel(Stopwatch stopwatch)
    {
        stopwatch.Stop();
        this.ElapsedTime = $"{stopwatch.ElapsedMilliseconds}";
    }

    [RelayCommand]
    private void ChangePage()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        this.FrameContent = new SecondPage(stopwatch);
    }
}
