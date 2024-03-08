namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class DownloadFilePage : Page
{
    public DownloadFilePage()
    {
        this.InitializeComponent();
        this.DataContext = new DownloadFileViewModel();
    }
}
