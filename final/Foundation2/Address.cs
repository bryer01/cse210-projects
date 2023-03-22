public class Address
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public bool IsNotInUSA => !IsInUSA();

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string FullAddress()
    {
        return street + ", " + city + ", " + state + ", " + country;
    }
}
