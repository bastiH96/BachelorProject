namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class ThousendTasksPage : ContentPage
{
    public ThousendTasksPage(ThousendTasksPageViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
