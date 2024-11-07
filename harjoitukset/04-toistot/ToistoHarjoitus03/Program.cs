string sana;
string[] sanat = new string[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("kirjoita sana: ");
    sana = Console.ReadLine();
    sanat[i] = sana;
}

for (int j = 2; j >= 0; j--)
{
    Console.WriteLine(sanat[j]);
}