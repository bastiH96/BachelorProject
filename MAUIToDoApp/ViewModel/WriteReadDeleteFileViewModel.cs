namespace MAUIToDoApp.ViewModel;

using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class WriteReadDeleteFileViewModel : ObservableObject
{
    [ObservableProperty] private string elapsedTime;

    [RelayCommand]
    public async Task FileWriteReadDeleteAsync()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = 0; i < 100; i++)
        {
            var filePath = Path.Combine("D:\\TestData", "largeFile.txt");

            var data = new byte[1024 * 1024];

            await File.WriteAllBytesAsync(filePath, data);

            var _ = await File.ReadAllBytesAsync(filePath);

            File.Delete(filePath);
        }
        stopwatch.Stop();
        this.ElapsedTime = stopwatch.ElapsedMilliseconds.ToString();
        stopwatch.Reset();
    }
}
