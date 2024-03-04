namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
