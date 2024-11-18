int summa = 0;
for (int i = 0; i < 3; i++)
{
    Console.Write("luku 1-100: ");
    int luku = int.Parse(Console.ReadLine());
    summa += luku;
}

int ka = summa / 3;

if (ka >= 50)
{
    Console.WriteLine("Hyväksytty");
}
else
{
    Console.WriteLine("Hylätty");
}