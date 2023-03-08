using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class TimedActivity : Activity
{
    public int Time { get; set; }
    public int CountdownDuration { get; set; } = 3;
    public bool IsRunning { get; set; }

    protected void StartCountdown()
    {
        var countdown = CountdownDuration;
        Console.WriteLine($"Starting in {countdown}...");
        System.Threading.Thread.Sleep(1000);
        countdown--;
        while (countdown > 0)
        {
            Console.WriteLine(countdown + "...");
            System.Threading.Thread.Sleep(1000);
            countdown--;
        }
        StartActivity();
    }

    protected async void StartActivity()
    {
        IsRunning = true;
        await Task.Delay(Time * 1000);
        IsRunning = false;
    }
}
