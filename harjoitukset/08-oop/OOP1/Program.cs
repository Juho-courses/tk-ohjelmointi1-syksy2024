Car c1 = new Car("Fiat");
Console.WriteLine(c1.Manufacturer);
Console.WriteLine(c1.Mileage);
c1.Drive(120);
Console.WriteLine(c1.Mileage);

class Car
{
    // ominaisuudet, properties
    public string Manufacturer { get; private set; }
    public int Mileage { get; private set; }

    // Konstruktori
    public Car(string manufacturer)
    {
        Manufacturer = manufacturer;
        Mileage = 0;
    }

    // Metodit
    public void Drive(int distance)
    {
        Mileage += distance;
    }
}