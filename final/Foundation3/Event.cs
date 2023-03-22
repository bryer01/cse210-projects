using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    public string Title { get; internal set; }
    public DateTime Date { get; internal set; } // added Date property
    public DateTime Time { get; internal set; }
    public Address Address { get; internal set; }

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string ToShortDateString()
    {
        return Date.ToShortDateString(); // modified to use Date property
    }

    public string GetFullDetails()
    {
        return $"{title}, {description}, {date.ToString("dd/MM/yyyy")}, {time.ToString("hh:mm tt")}, {address.GetFullAddress()}";
    }

    public string GetShortDetails()
    {
        return $"{title}, {date.ToString("dd/MM/yyyy")}";
    }

    protected virtual string GetTypeSpecificDetails()
    {
        return "";
    }
}
