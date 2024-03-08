namespace WPFToDoApp.View;

using System.Diagnostics;
using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class ChangePageView : Page
{
    public ChangePageView(Stopwatch stopwatch)
    {
        this.InitializeComponent();
        this.DataContext = new ChangePageViewModel(stopwatch);
    }
}
