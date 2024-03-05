namespace MAUIToDoApp.View;

using MAUIToDoApp.ViewModel;

public partial class MathematicalCalcPage : ContentPage
{
    public MathematicalCalcPage(MathematicalCalcPageViewModel vm)
    {
        this.InitializeComponent();
        this.BindingContext = vm;
    }
}
