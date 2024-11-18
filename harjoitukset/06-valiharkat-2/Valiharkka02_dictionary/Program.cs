Dictionary<int, int> kuukaudet = new Dictionary<int, int>();

kuukaudet.Add(1, 31);
kuukaudet.Add(2, 28);
kuukaudet.Add(3, 31);
kuukaudet.Add(4, 30);
kuukaudet.Add(5, 31);
kuukaudet.Add(6, 30);
kuukaudet.Add(7, 31);
kuukaudet.Add(8, 31);
kuukaudet.Add(9, 30);
kuukaudet.Add(10, 31);
kuukaudet.Add(11, 30);
kuukaudet.Add(12, 31);

Console.Write("Kuukauden numero (1-12): ");
int kk = int.Parse(Console.ReadLine());

if (kk < 1 || kk > 12)
{
    Console.WriteLine("väärä valinta");
}
else
{
    Console.WriteLine($"{kk}. kuukaudessa on {kuukaudet[kk]} päivää");
}
