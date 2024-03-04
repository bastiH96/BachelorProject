namespace WPFToDoApp.View;

using System.Windows;
using WpfMauiLibrary.HelperClasses;
using WPFToDoApp.ViewModel;

public partial class MainView : Window
{
    public MainView()
    {
        DbHelper.CreateWpfDatabase();
        this.InitializeComponent();
        this.DataContext = new MainViewModel();
    }
}
