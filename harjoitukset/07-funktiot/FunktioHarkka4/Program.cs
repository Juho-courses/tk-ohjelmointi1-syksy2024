// Luo funktio, jolla on kaksi argumenttia: k(int) ja the_list(int[]). Funktio
// palauttaa kokonaisluvun, joka kertoo moniko the_list-arrayn jäsen on 
// arvoltaan suurempi tai yhtä suuri kuin k.
// • FilterNumbers(3, [1, 2, 3, 4, 5]) palauttaa kokonaisluvun 3
// • FilterNumbers(6, [1, 2, 3, 4, 5]) palauttaa kokonaisluvun 0

int FilterNumbers(int k, int[] the_list)
{
    int over_k = 0;

    foreach (var item in the_list)
    {
        if (item >= k)
        {
            over_k++;
        }
    }

    return over_k;
}

Console.WriteLine(FilterNumbers(3, new int[] { 1, 2, 3, 4, 5 }));
Console.WriteLine(FilterNumbers(6, new int[] { 1, 2, 3, 4, 5 }));


int FilterNumbers2(int k, int[] the_list)
{
    return the_list.Where(x => x >= k).Count();
}

Console.WriteLine(FilterNumbers2(3, [1, 2, 3, 4, 5]));
Console.WriteLine(FilterNumbers2(6, [1, 2, 3, 4, 5]));