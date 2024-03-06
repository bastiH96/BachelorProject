namespace WPFToDoApp.ViewModel;

using System;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class ChangePageViewModel : ObservableObject
{
    [ObservableProperty] private string elapsedTime;
    public ChangePageViewModel(long startTime)
    {
        var endTime = DateTime.Now.Ticks;
        var timeSpan = (endTime - startTime) / TimeSpan.TicksPerMillisecond;
        this.ElapsedTime = timeSpan.ToString();
    }
}
