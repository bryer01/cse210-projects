public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string Speaker { get; internal set; }
    public string Capacity { get; internal set; }

    protected override string GetTypeSpecificDetails()
    {
        return $"{speaker}, {capacity}";
    }
}