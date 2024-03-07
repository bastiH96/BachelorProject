namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class WriteReadDeleteFilePage : ContentPage
{
    public WriteReadDeleteFilePage(WriteReadDeleteFileViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
