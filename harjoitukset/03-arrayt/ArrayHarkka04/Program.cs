string[] drinks = { "maito", "vesi", "kahvi", "tee", "limsa" };

Console.WriteLine("Vaihtoehdot:");

int idx = 0;
Console.WriteLine(idx + ": " + drinks[idx]);
idx = idx + 1;

Console.WriteLine(idx + ": " + drinks[idx]);
idx = idx + 1;

Console.WriteLine(idx + ": " + drinks[idx]);
idx = idx + 1;

Console.WriteLine(idx + ": " + drinks[idx]);
idx = idx + 1;

Console.WriteLine(idx + ": " + drinks[idx]);

Console.Write("Valintasi [0-" + (drinks.Length - 1) + "]: ");
string drink_str = Console.ReadLine();

int drink = int.Parse(drink_str);

if (drink >= 0 && drink < drinks.Length)
{
    Console.WriteLine(drinks[drink] + "! Hyvä valinta.");
}
else
{
    Console.WriteLine("viallinen vaihtoehto");
}
