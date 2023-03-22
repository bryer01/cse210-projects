public class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public string Weather { get; internal set; }

    protected override string GetTypeSpecificDetails()
    {
        return $"{weather}";
    }
}