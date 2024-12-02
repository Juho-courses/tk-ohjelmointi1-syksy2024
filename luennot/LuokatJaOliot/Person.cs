class Person
{
    private string name;

    public string Name
    {
        private set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public string LastName { private set; get; }

    public Person(string _name, string _lastname)
    {
        name = _name;
        LastName = _lastname;
    }
    public void Greet()
    {
        Console.WriteLine($"Moi! mun nimi on {name}");
    }
}