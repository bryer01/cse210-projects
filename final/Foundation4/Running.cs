public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetPace()
    {
        return GetPace(distance);
    }

    public double GetSpeed()
    {
        return GetSpeed(distance);
    }

    public override string GetSummary()
    {
        double distanceInMiles = distance * 0.62;
        double paceInMinutesPerMile = GetPace() * 60;
        double speedInMph = GetSpeed() * 0.621;
        return string.Format("{0} Running - Distance {1:0.00} miles, Speed {2:0.00} mph, Pace {3:0.00} min/mi.",
        date.ToString("dd MMM yyyy"), distanceInMiles, speedInMph, paceInMinutesPerMile);
    }


    private new double GetSpeed(double distance)
    {
        return (distance / minutes) * 60;
    }

    private new double GetPace(double distance)
    {
        return minutes / distance;
    }
}