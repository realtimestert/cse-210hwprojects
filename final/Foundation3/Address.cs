public class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country)
    {
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
    }

    public string GetAddressString()
    {
        return $"{Street}, \n{City}, {State} {Country}";
    }
}