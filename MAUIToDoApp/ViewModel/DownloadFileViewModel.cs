namespace MAUIToDoApp.ViewModel;

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class DownloadFileViewModel : ObservableObject
{
    [ObservableProperty] private string? elapsedTime;

    [RelayCommand]
    public async Task DownloadFileAsync()
    {
        var url = "https://speed.cloudflare.com/__down?bytes=1048576";
        using var httpClient = new HttpClient();

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                // Handle error
                return;
            }

            var data = await response.Content.ReadAsByteArrayAsync();

            stopwatch.Stop();
            this.ElapsedTime = $"{stopwatch.ElapsedMilliseconds}";
            stopwatch.Reset();
        }
        catch (Exception)
        {
            // Handle exceptions
        }
    }

}
