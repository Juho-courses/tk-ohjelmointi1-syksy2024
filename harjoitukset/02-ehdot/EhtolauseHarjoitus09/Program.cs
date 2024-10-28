Console.Write("Anna sana:");
string sana1 = Console.ReadLine();

Console.Write("Anna sana:");
string sana2 = Console.ReadLine();

if ((sana1 == "koulu" && sana2 == "ohjelmointi") || (sana1 == "ohjelmointi" && sana2 == "koulu"))
{
    Console.WriteLine("Hienot sanat!");
}
else
{
    Console.WriteLine("Ei huonot sanat.");
}