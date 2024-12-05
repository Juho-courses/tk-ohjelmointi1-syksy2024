class Person
{
    public string FirstName { get; private set; }
    public int Age { get; private set; }
    public Address Address { get; private set; }

    public Person(string name, int age)
    {
        FirstName = name;
        Age = age;
    }

    public void SetAddress(Address osoite)
    {
        Address = osoite;
    }

    public int MakeOlder()
    {
        Age++;
        return Age;
    }
}