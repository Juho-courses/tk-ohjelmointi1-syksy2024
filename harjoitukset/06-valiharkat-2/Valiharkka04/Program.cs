Random r = new Random();

int arvottu_luku = r.Next(0, 101);
Console.WriteLine(arvottu_luku);

int arvausmaara = 0;
int arvaus;
while (true)
{
    Console.Write("Arvaa luku väliltä 0-100: ");
    arvaus = int.Parse(Console.ReadLine());
    arvausmaara++;

    if (arvaus < arvottu_luku)
    {
        Console.WriteLine("Arvauksesi on liian pieni!");
    }
    else if (arvaus == arvottu_luku)
    {
        Console.WriteLine("Oikein!");
        break;
    }
    else
    {
        Console.WriteLine("Arvauksesi on liian suuri!");
    }
}

Console.WriteLine($"Sinulla meni {arvausmaara} kertaa arvataksesi oikein.");