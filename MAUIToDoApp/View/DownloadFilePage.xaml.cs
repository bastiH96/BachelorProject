namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class DownloadFilePage : ContentPage
{
    public DownloadFilePage(DownloadFileViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
