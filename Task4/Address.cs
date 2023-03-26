namespace Task4;

public class Address
{
    public string Street { get; }
    public int Postcode { get; }
    public string City { get; }
    public string Country { get; }

    public int BuildingNumber { get; set; }

    public int Apartment { get; set; }

    public Address(string street, int postcode, string city, string country, int buildingNumber, int apartment)
    {
        Street = street;
        Postcode = postcode;
        City = city;
        Country = country;
        BuildingNumber = buildingNumber;
        Apartment = apartment;

    }
}