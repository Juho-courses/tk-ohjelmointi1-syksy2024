string sana;
int word_count = 0;
string shortest_word = "ei asetettu";
string longest_word = "ei asetettu";
string first_word = "";
string last_word = "";

for (int i = 0; i < 10; i++)
{
    Console.Write("kirjoita sana (\"lopeta\" lopettaa): ");
    sana = Console.ReadLine();
    if (sana == "lopeta") { break; }
    word_count++;

    last_word = sana;
    if (i == 0) { first_word = sana; }

    if (shortest_word == "ei asetettu")
    {
        shortest_word = sana;
    }
    if (shortest_word.Length > sana.Length)
    {
        shortest_word = sana;
    }

    if (longest_word == "ei asetettu") { longest_word = sana; }
    if (longest_word.Length < sana.Length)
    {
        longest_word = sana;
    }

}

Console.WriteLine($"Syötit {word_count} sanaa");


if (word_count > 0)
{
    Console.WriteLine($"Ensimmäinen sana: {first_word}");
    Console.WriteLine($"Viimeinen sana: {last_word}");
    Console.WriteLine($"Lyhyin sana: {shortest_word}");
    Console.WriteLine($"Pisin sana: {longest_word}");
}

