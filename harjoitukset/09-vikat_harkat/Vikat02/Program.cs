Console.Write("positiivinen luku 1:");
int luku1 = int.Parse(Console.ReadLine());
Console.Write("positiivinen luku 2:");
int luku2 = int.Parse(Console.ReadLine());

if (luku1 < 0 || luku2 < 0)
{
    Console.WriteLine("Huonot luvut");
}
else
{
    Random r = new Random();
    int arvottu = r.Next(luku1, luku2);
    Console.WriteLine(arvottu);
}