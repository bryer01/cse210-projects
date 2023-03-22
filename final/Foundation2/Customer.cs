public class Customer
{
    public string name { get; set; }
    public Address address { get; set; }

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string FullAddress()
    {
        return address.street + ", " + address.city + ", " + address.state + ", " + address.country;
    }
    public bool IsInUSA()
    {
        return address.country == "USA";
    }
    public string FullAddress2()
    {
        return address.street + ", " + address.city + ", " + address.state + ", " + address.country;
    }
    public bool IsNotInUSA()
    {
        return address.country == "Not In USA";
    }
}
