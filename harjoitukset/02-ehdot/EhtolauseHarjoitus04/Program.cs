int value = 101;

if (value < 100)
{
    Console.WriteLine("arvo on aika pieni");
}
else if (value == 100)
{
    Console.WriteLine("arvo on sata");
}
else if (value > 100 && value <= 200)
{
    Console.WriteLine("nyt alkaa olla aika iso luku");
}
else if (value > 200)
{
    Console.WriteLine("nyt ollaa isoissa luvuissa");
}