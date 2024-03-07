namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class WriteReadDeleteFilePage : Page
{
    public WriteReadDeleteFilePage()
    {
        this.InitializeComponent();
        this.DataContext = new WriteReadDeleteFileViewModel();
    }
}
