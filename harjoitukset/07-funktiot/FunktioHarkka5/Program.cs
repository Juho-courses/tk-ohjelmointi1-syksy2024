// Kirjoita funktio joka palauttaa sille argumenttina annettavan
// kokonaislukuarrayn suurimman jäsenen
// • [1,3,4,5] palauttaa 5
// • [16,32,4,5] palauttaa 32

int GreatestValue(int[] nums)
{
    int greatest = nums[0];
    foreach (var item in nums)
    {
        if (item > greatest) greatest = item;
    }

    return greatest;
}

int MaxValue(int[] nums)
{
    return nums.Max();
}

Console.WriteLine(GreatestValue([1, 3, 4, 5]));
Console.WriteLine(GreatestValue([16, 32, 4, 5]));
// • [1,3,4,5] palauttaa 5
// • [16,32,4,5] palauttaa 32
Console.WriteLine(MaxValue([1, 3, 4, 5]));
Console.WriteLine(MaxValue([16, 32, 4, 5]));