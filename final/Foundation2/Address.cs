public class Address
{
    string StreetAddress {get; set;}
    string City {get; set;}
    string StateOrProvince {get; set;}
    string Country {get; set;}

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }

}