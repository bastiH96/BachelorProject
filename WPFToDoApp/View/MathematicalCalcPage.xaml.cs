namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;

public partial class MathematicalCalcPage : Page
{
    public MathematicalCalcPage()
    {
        this.InitializeComponent();
        this.DataContext = new MathematicalCalcPageViewModel();
    }
}
