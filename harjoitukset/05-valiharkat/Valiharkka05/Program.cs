int luku;
int summa = 0;
int maara = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"anna {i + 1}. luku: ");
    luku = int.Parse(Console.ReadLine());

    if (luku % 2 == 0)
    {
        summa += luku;
        maara++;
    }
}

Console.WriteLine($"Parillisten summa: {summa}");
Console.WriteLine($"Parillisten keskiarvo: {summa / (float)maara}");