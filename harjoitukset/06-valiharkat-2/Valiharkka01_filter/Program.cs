int luku;
string syote = "";
List<int> luvut = new List<int>();
while (true)
{
    Console.Write("Syötä kokonaisluku (\"lopeta\" lopettaa): ");
    syote = Console.ReadLine();

    if (syote == "lopeta")
    {
        break;
    }

    luku = int.Parse(syote);
    luvut.Add(luku);
}

List<int> parilliset = luvut.FindAll(n => n % 2 == 0);
List<int> parittomat = luvut.FindAll(n => n % 2 != 0);

Console.WriteLine("PARILLISET:");
foreach (var arvo in parilliset)
{
    Console.WriteLine(arvo);
}

Console.WriteLine("PARITTOMAT");
foreach (var arvo in parittomat)
{
    Console.WriteLine(arvo);
}