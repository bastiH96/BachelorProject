namespace WPFToDoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFToDoApp.View;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private object frameContent;

    [RelayCommand]
    public void OpenTaskPage() => this.FrameContent = new TaskPage();

    [RelayCommand]
    public void OpenThousendTasksPage() => this.FrameContent = new ThousendTasksPage();
}
