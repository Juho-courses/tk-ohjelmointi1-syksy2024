int luku;
string syote = "";
int[] luvut = new int[1000];
int index = 0;
while (true)
{
    Console.Write("Syötä kokonaisluku (\"lopeta\" lopettaa): ");
    syote = Console.ReadLine();

    if (syote == "lopeta")
    {
        break;
    }

    luku = int.Parse(syote);
    luvut[index] = luku;
    index++;
    if (index == luvut.Length) { break; }

}

int[] parilliset = new int[1000];
int[] parittomat = new int[1000];
int parilliset_maara = 0;
int parittomat_maara = 0;

for (int i = 0; i < index; i++)
{
    // Console.WriteLine(luvut[i]);
    if (luvut[i] % 2 == 0)
    {
        parilliset[parilliset_maara] = luvut[i];
        parilliset_maara++;
    }
    else
    {
        parittomat[parittomat_maara] = luvut[i];
        parittomat_maara++;
    }
}

Console.WriteLine("PARILLISET:");
for (int i = 0; i < parilliset_maara; i++)
{
    Console.WriteLine(parilliset[i]);
}

Console.WriteLine("PARITTOMAT:");
for (int i = 0; i < parittomat_maara; i++)
{
    Console.WriteLine(parittomat[i]);
}