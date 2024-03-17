namespace WPFToDoApp.View;

using System.Diagnostics;
using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class ChangePageView : Page
{
    public ChangePageView()
    {
        this.InitializeComponent();
        this.DataContext = new ChangePageViewModel();
    }
}
