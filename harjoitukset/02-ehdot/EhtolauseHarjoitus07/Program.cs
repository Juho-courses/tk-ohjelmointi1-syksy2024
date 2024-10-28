Console.Write("sana 1: ");
string sana1 = Console.ReadLine();

Console.Write("sana 2: ");
string sana2 = Console.ReadLine();

if (sana1.Length > sana2.Length)
{
    Console.WriteLine(sana1);
}
else if (sana2.Length > sana1.Length)
{
    Console.WriteLine(sana2);
}
else
{
    int pituus = sana1.Length + sana2.Length;
    Console.WriteLine(pituus);
}