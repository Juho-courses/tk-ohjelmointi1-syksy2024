// Kirjoita ohjelma joka tulostaa kertotaulut luvuille 1, 2 ja 3. Jokainen
// operaatio tulostetaan omalle rivilleen.
// • Yksi rivi outputissa: "2 * 3 = 6

void TulostaKertotauluLuvulle(int luku)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} * {luku} = {i * luku}");
    }
}

// TulostaKertotauluLuvulle(1);
// TulostaKertotauluLuvulle(2);
// TulostaKertotauluLuvulle(3);

// Käyttäen edellistä tehtävää hyödyksi, kirjoita funktio joka ottaa
// argumenttina vastaan tiedon isoimmasta tulostettavasta kertotaulusta ja
// tulostaa kertotaulut annettuun lukuun asti.
// • TeeKertotaulut(8) tulostaa kertotaulut luvuille 1,2,3,4,5,6,7 ja 8

void TeeKertotaulut(int n)
{
    for (int i = 1; i <= n; i++)
    {
        TulostaKertotauluLuvulle(i);
    }
}

TeeKertotaulut(8);