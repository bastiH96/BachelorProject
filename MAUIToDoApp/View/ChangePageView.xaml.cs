namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class ChangePageView : ContentPage
{
    public ChangePageView(ChangePageViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
