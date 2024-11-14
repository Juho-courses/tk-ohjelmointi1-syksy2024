Console.Write("kokonaisluku: ");
int luku = int.Parse(Console.ReadLine());

if (luku < 0)
{
    Console.WriteLine("negatiivinen");
}
else if (luku == 0)
{
    Console.WriteLine("nolla");
}
else
{
    Console.WriteLine("positiivinen");
}