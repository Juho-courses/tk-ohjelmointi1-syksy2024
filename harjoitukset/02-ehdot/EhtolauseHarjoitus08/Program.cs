Console.Write("Valitse joko a tai b: ");

string valinta = Console.ReadLine();

if (valinta == "a")
{
    Console.WriteLine("hieno valinta");
}
else if (valinta == "b")
{
    Console.WriteLine("loistava valinta");
}
else
{
    Console.WriteLine("virheellinen syöte!");
}