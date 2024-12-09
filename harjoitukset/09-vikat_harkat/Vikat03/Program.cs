Console.Write("Montako lukua arvotaan:");
int maara = int.Parse(Console.ReadLine());

Random r = new Random();
for (int i = 0; i < maara; i++)
{
    Console.WriteLine(r.Next(1, 51));
}
