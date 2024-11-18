int TulostaSanaJaPalautaSenPituus(string sana, bool palautaPituus)
{
    if (!palautaPituus) { return 0; }
    Console.WriteLine("tulostetaan: " + sana);
    return sana.Length;
}
Console.WriteLine(TulostaSanaJaPalautaSenPituus("koira", true));
int pituus = TulostaSanaJaPalautaSenPituus("kissa", false);
Console.WriteLine(pituus);
