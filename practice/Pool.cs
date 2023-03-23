public class Pool
{
    private int laps;

    public Pool(int laps)
    {
        this.laps = laps;
    }

    public double GetDistance()
    {
        return laps * 50.0;
    }

    public double GetSpeed()
    {
        // assume an average lap time of 1 minute
        return 50.0 / 60.0;
    }

    public double GetPace()
    {
        // assume an average lap time of 1 minute
        return 1.0;
    }

    public string GetSummary()
    {
        return laps + " laps";
    }

    public double GetDistanceInKm()
    {
        return GetDistance() / 1000;
    }

    public double GetDistanceInMiles()
    {
        return GetDistanceInKm() * 0.62;
    }

    public double GetSpeedInKph()
    {
        return GetSpeed() * 3.6;
    }

    public double GetSpeedInMph()
    {
        return GetSpeedInKph() / 1.609;
    }

    public double GetPaceInKm()
    {
        return GetPace() * 60;
    }

    public double GetPaceInMiles()
    {
        return GetPace() * 60 / 1.609;
    }
}