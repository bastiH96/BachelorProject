namespace MAUIToDoApp;

using MAUIToDoApp.View;
using MAUIToDoApp.ViewModel;
using Microsoft.Extensions.Logging;
using WpfMauiLibrary.HelperClasses;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        DbHelper.CreateMauiDatabase();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<ThousendTasksPage>();
        builder.Services.AddSingleton<ThousendTasksPageViewModel>();
        builder.Services.AddSingleton<MathematicalCalcPage>();
        builder.Services.AddSingleton<MathematicalCalcPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
