namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class ChangePageView : Page
{
    public ChangePageView(long startTime)
    {
        this.InitializeComponent();
        this.DataContext = new ChangePageViewModel(startTime);
    }
}
