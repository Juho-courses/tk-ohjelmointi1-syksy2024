// Luo funktio, joka ottaa vastaan argumenttina arrayn ja tulostaa sen arvot
// omille riveilleen
void TulostaArray(int[] nums)
{
    foreach (int numero in nums)
    {
        Console.WriteLine(numero);
    }
}
TulostaArray(new int[] { 1, 2, 3, 34 });
