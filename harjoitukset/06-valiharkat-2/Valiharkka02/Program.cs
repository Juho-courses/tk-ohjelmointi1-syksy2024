Console.Write("Kuukauden numero (1-12): ");
int kk = int.Parse(Console.ReadLine());

if (kk == 1)
{
    Console.WriteLine("Tammikuussa on 31 päivää");
}
else if (kk == 2)
{
    Console.WriteLine("Helmikuussa on 28 päivää");
}
else if (kk == 3)
{
    Console.WriteLine("Maaliskuussa on 31 päivää");
}
else if (kk == 4)
{
    Console.WriteLine("Huhtikuussa on 30 päivää");
}
else if (kk == 5)
{
    Console.WriteLine("Toukokuussa on 31 päivää");
}
else if (kk == 6)
{
    Console.WriteLine("Kesäkuussa on 30 päivää");
}
else if (kk == 7)
{
    Console.WriteLine("Heinäkuussa on 31 päivää");
}
else if (kk == 8)
{
    Console.WriteLine("Elokuussa on 31 päivää");
}
else if (kk == 9)
{
    Console.WriteLine("Syyskuussa on 30 päivää");
}
else if (kk == 10)
{
    Console.WriteLine("Lokakuussa on 31 päivää");
}
else if (kk == 11)
{
    Console.WriteLine("Marraskuussa on 30 päivää");
}
else if (kk == 12)
{
    Console.WriteLine("Joulukuussa on 31 päivää");
}
else
{
    Console.WriteLine("Väärä valinta");
}