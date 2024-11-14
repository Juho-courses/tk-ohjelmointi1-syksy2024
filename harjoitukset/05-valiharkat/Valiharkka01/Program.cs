// Kirjoita ohjelma, joka kysyy käyttäjältä numeroa ja kertoo onko syötetty
// luku parillinen vai pariton.
Console.Write("anna numero: ");

// luetaan syöte
string luku_str = Console.ReadLine();

// tyyppimuunnos
// jos pystyy muuttamaan intiksi, tallennetaan arvo luku-muuttujaan ja success saa arvon true
// jos EI pysty muuttamaan intiksi, success saa arvon false ja luku arvo on 0
bool success = int.TryParse(luku_str, out int luku);

// muunnos onnistui
if (success)
{
    // tarkastetaan parillisuus
    if (int.IsEvenInteger(luku))
    {
        Console.WriteLine("parillinen");
    }
    else
    {
        Console.WriteLine("pariton");
    }
}
else
{
    Console.WriteLine("et syöttänyt kokonaislukua");
}