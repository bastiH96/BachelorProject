namespace MAUIToDoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class MathematicalCalcPageViewModel : ObservableObject
{
    [ObservableProperty] private string stopwatchTime;

    [RelayCommand]
    private async Task MathematicalCalc()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (var x = 0; x < 50; x++)
        {
            var iterations = 1000000; // Number of iterations to approximate pi
            var tasks = new List<Task<double>>();

            static double ApproximatePi(int iterations)
            {
                double sum = 0;
                for (var i = 0; i < iterations; i++)
                {
                    var term = Math.Pow(-1, i) / ((2 * i) + 1);
                    sum += term;
                }
                return sum * 4;
            }

            for (var i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    var pi = ApproximatePi(iterations);
                    return pi;
                }));
            }

            await Task.WhenAll(tasks);
        }
        stopwatch.Stop();
        this.StopwatchTime = stopwatch.Elapsed.Milliseconds.ToString();
        stopwatch.Reset();
    }
}
