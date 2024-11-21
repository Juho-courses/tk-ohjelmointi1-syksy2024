// Luo funktio, jolla on kokonaislukuargumentti nimeltä ’n’. Funktio palauttaa
// arrayn jossa on kokonaisluvut 0 - n.
// • LuoArray(5) palauttaa [0,1,2,3,4,5]

int[] LuoArray(int n)
{
    int[] ints = new int[n + 1];
    for (int i = 0; i <= n; i++)
    {
        ints[i] = i;
    }
    return ints;
}

int[] nums = LuoArray(0);

TulostaArray(nums);

void TulostaArray(int[] nums)
{
    foreach (int luku in nums)
    {
        Console.Write(luku + ", ");
    }
}