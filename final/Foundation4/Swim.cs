public class Swim : Activity
{
    private int laps;

    public Swim(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // each lap is 50 meters
        return laps * 50.0 / 1000;
    }

    public override double GetPace()
    {
        // pace is time per km
        return minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Swim - Distance: {GetDistance():0.00} km, Pace: {GetPace():0.00} min/km";
    }
}
