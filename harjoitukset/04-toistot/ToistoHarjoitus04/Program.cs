string sana;
string[] sanat = new string[3];

int i = 0;
while (i < 3)
{
    Console.Write("kirjoita sana: ");
    sana = Console.ReadLine();
    sanat[i] = sana;
    i++;
}

int j = 2;
while (j >= 0)
{
    Console.WriteLine(sanat[j]);
    j--;
}