class Address
{
    public string Street { get; private set; }
    public int StreetNumber { get; private set; }

    public Address(string street, int streetNumber)
    {
        Street = street;
        StreetNumber = streetNumber;
    }

    public void ChangeAddress(string street, int streetNumber)
    {
        Street = street;
        StreetNumber = streetNumber;
    }

    public void Print()
    {
        Console.WriteLine($"{Street}, {StreetNumber}");
    }
}