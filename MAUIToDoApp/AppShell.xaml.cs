namespace MAUIToDoApp;

using MAUIToDoApp.View;

public partial class AppShell : Shell
{
    public AppShell()
    {
        this.InitializeComponent();

        Routing.RegisterRoute(nameof(SecondPageView), typeof(SecondPageView));
    }
}
