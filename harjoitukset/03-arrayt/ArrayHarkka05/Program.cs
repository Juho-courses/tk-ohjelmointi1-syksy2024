// kysy luvut
int[] luvut = new int[3];

Console.Write("Anna luku: ");
int luku1 = int.Parse(Console.ReadLine());
luvut[0] = luku1;

Console.Write("Anna luku: ");
int luku2 = int.Parse(Console.ReadLine());
luvut[1] = luku2;

Console.Write("Anna luku: ");
int luku3 = int.Parse(Console.ReadLine());
luvut[2] = luku3;

Console.Write("Suoritetaanko luvuille kertolasku (*), summaus(+) vai vähennys(-) ? ");

string operaatio = Console.ReadLine();
int vastaus = 0;

if (operaatio == "*")
{
    vastaus = luvut[0] * luvut[1] * luvut[2];
}
else if (operaatio == "+")
{
    vastaus = luvut[0] + luvut[1] + luvut[2];
}
else if (operaatio == "-")
{
    vastaus = luvut[0] - luvut[1] - luvut[2];
}

Console.WriteLine($"{luvut[0]}{operaatio}{luvut[1]}{operaatio}{luvut[2]}={vastaus}");
