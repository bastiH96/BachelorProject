namespace MAUIToDoApp.ViewModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIToDoApp.View;

public partial class ChangePageViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty] private string elapsedTime;

    [RelayCommand]
    public async Task ChangePage()
    {
        IDictionary<string, object> startTime = new Dictionary<string, object>()
        {
            {"startTime", DateTime.Now.Ticks }
        };
        await Shell.Current.GoToAsync(nameof(SecondPageView), startTime);
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var startTime = (long)query["startTime"];
        var endTime = DateTime.Now.Ticks;
        var timeSpan = (endTime - startTime) / TimeSpan.TicksPerMillisecond;
        this.ElapsedTime = timeSpan.ToString();
    }
}
