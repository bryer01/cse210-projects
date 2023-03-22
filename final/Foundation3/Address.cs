public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetFullAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }

    public string ToShortDateString()
    {
        // Assuming that "date" is the string representation of the date in your desired format
        // For example, "22/03/2023"
        DateTime date = DateTime.ParseExact(this.street, "dd/MM/yyyy", null);
        return date.ToShortDateString();
    }
}
