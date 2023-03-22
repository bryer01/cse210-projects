
public class Reception : Event
{
    private string rsvp;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        this.rsvp = rsvp;
    }

    public string RSVP { get; internal set; }

    protected override string GetTypeSpecificDetails()
    {
        return $"{rsvp}";
    }


}