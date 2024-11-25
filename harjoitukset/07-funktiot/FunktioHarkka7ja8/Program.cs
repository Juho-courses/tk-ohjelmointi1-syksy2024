// Kirjoita funktio, jolla on kaksi argumenttia. Funktio tulostaa kahden
// annetun argumentin kertolaskun tuloksen.
// • Kertolasku(4, 5) tulostaa 2
void Kertolasku(int a, int b)
{
    Console.WriteLine(a * b);
}

Kertolasku(4, 5);

// Kirjoita funktio joka ottaa vastaan kaksi kokonaislukuargumenttia ja
// palauttaa niiden kertolaskun tuloksen.
// • ET saa käyttää kertolasku-operaatiota (*)
// • Ei tarvitse käsitellä negatiivisia lukuja

// toimii negativiisilla luvuilla jos a on neg
// jos b neg, ei toimi
int Kertolasku2(int a, int b)
{
    int tulo = 0;
    for (int i = 0; i < b; i++)
    {
        tulo += a;
    }
    return tulo;
}
Console.WriteLine(Kertolasku2(4, 5));
Console.WriteLine(Kertolasku2(12, 4));