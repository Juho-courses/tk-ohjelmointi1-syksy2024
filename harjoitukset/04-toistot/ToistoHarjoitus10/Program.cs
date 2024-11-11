string[] words = new string[10];

string sana;
int word_count = 0;

for (int i = 0; i < words.Length; i++)
{
    Console.Write("kirjoita sana (\"lopeta\" lopettaa): ");
    sana = Console.ReadLine();
    if (sana == "lopeta") { break; }
    words[i] = sana;
    word_count++;
}

Console.WriteLine($"Syötit {word_count} sanaa");


if (word_count > 0)
{
    Console.WriteLine($"Ensimmäinen sana: {words[0]}");
    Console.WriteLine($"Viimeinen sana: {words[word_count - 1]}");

    string shortest = words[0];
    string longest = words[word_count - 1];

    for (int i = 0; i < word_count; i++)
    {
        string word = words[i];
        if (word.Length < shortest.Length)
        {
            shortest = word;
        }
        if (word.Length > longest.Length)
        {
            longest = word;
        }
    }

    Console.WriteLine($"Lyhyin sana: {shortest}");
    Console.WriteLine($"Pisin sana: {longest}");
}

