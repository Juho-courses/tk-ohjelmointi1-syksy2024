// tarkistetaan kaikki luvut
for (int i = 0; i < 101; i++)
{
    if (i % 16 == 0)
    {
        Console.WriteLine(i);
    }
}

// generoidaan vain 16 jaolliset luvut
for (int i = 0; i < 101; i += 16)
{
    Console.WriteLine(i);
}