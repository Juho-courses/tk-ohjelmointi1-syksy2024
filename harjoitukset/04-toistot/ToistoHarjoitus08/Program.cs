string[] words = ["moi", "ei", "joo", "kyllä"];

foreach (string word in words)
{
    if (word.Length < 3) { continue; }
    Console.WriteLine(word);
}
