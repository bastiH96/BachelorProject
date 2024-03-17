namespace WPFToDoApp.View;

using System.Diagnostics;
using System.Windows.Controls;
using WPFToDoApp.ViewModel;

/// <summary>
/// Interaction logic for SecondPage.xaml
/// </summary>
public partial class SecondPage : Page
{
    public SecondPage(Stopwatch stopwatch)
    {
        this.InitializeComponent();
        this.DataContext = new ChangePageViewModel(stopwatch);
    }
}
