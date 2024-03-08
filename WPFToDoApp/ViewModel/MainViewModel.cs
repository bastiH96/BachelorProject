namespace WPFToDoApp.ViewModel;

using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFToDoApp.View;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private object? frameContent;

    [RelayCommand]
    public void OpenTaskPage() => this.FrameContent = new TaskPage();

    [RelayCommand]
    public void OpenThousendTasksPage() => this.FrameContent = new ThousendTasksPage();

    [RelayCommand]
    public void OpenMathematicalCalcPage() => this.FrameContent = new MathematicalCalcPage();

    [RelayCommand]
    public void OpenChangePageView()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        this.FrameContent = new ChangePageView(stopwatch);
    }

    [RelayCommand]
    public void OpenWriteReadDeleteFilePage() => this.FrameContent = new WriteReadDeleteFilePage();

    [RelayCommand]
    public void DownloadFilePage() => this.FrameContent = new DownloadFilePage();
}
