namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class SecondPageView : ContentPage
{
    public SecondPageView(ChangePageViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
