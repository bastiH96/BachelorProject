namespace WPFToDoApp.ViewModel;

using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class ChangePageViewModel : ObservableObject
{
    [ObservableProperty] private string elapsedTime;
    public ChangePageViewModel(Stopwatch stopwatch)
    {
        stopwatch.Stop();
        this.ElapsedTime = $"{stopwatch.ElapsedMilliseconds}";
    }
}
