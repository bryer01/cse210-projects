using System;

public abstract class Activity
{
    public DateTime date;
    public int minutes;
    public abstract double GetDistance();
    public abstract double GetPace();
    public abstract string GetSummary();

    static void Main(string[] args)
    {
        DateTime date = new DateTime(2022, 11, 3);
        int minutes = 30;
        int laps = 60;
        Running running = new Running(date, minutes, 3.0);
        StationaryBicycle bicycle = new StationaryBicycle(date, minutes, 20.0);
        Swim swim = new Swim(date, minutes, laps);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(bicycle.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    protected double GetSpeed(double distance)
    {
        return (distance / minutes) * 60;
    }

    protected double GetPace(double distance)
    {
        return minutes / distance;
    }
}





