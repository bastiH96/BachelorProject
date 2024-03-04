namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class ThousendTasksPage : Page
{
    public ThousendTasksPage()
    {
        this.InitializeComponent();
        this.DataContext = new ThousendTaskPageViewModel();
    }
}
