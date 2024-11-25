// Kirjoita funktio, joka laskee argumenttina saatavan kokonaislukutaulukon 
// jäsenten summan ja tulostaa lasketun summan
// • LaskeSumma([1,2,3]) tulostaa 6

void LaskeSumma(int[] nums)
{
    int summa = 0;
    foreach (int num in nums)
    {
        summa += num;
    }
    Console.WriteLine(summa);
}

int LaskeSumma2(int[] nums)
{
    return nums.Sum();
}
LaskeSumma([1, 2, 3]);
LaskeSumma([5, 5]);

LaskeSumma2([1, 2, 3]);
LaskeSumma2([5, 5]);