public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (minutes / 60.0);
    }

    public override double GetPace()
    {
        return GetPace(GetDistance());
    }

    public double GetSpeed()
    {
        return speed;
    }

    public override string GetSummary()
    {
        double distanceInKm = GetDistance();
        double distanceInMiles = distanceInKm * 0.621;
        double paceInMinutesPerKm = GetPace();
        double paceInMinutesPerMile = paceInMinutesPerKm * 1.609;
        double speedInKph = GetSpeedInKph();
        double speedInMph = speedInKph / 1.609;

        string summary = String.Format("{0} {1} ({2} min) - Distance: {3:F2} km ({4:F2} mi), Speed: {5:F2} km/h ({6:F2} mph), Pace: {7}:{8:00} min/km ({9}:{10:00} min/mi)",
        date.ToString("dd MMM yyyy"), "Stationary Bicycle", minutes, distanceInKm, distanceInMiles, speedInKph, speedInMph, (int)paceInMinutesPerKm, (int)((paceInMinutesPerKm - (int)paceInMinutesPerKm) * 60), (int)paceInMinutesPerMile, (int)((paceInMinutesPerMile - (int)paceInMinutesPerMile) * 60));
        return summary;
    }

    private double GetSpeedInKph()
    {
        return speed;
    }
}
