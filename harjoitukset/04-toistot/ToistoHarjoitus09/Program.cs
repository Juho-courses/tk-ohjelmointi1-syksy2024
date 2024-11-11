int[] ints = new int[10];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = i * 10 - 2;
}

foreach (int i in ints)
{
    Console.WriteLine(i);
}

for (int i = 0; i < ints.Length - 1; i += 2)
{
    Console.WriteLine(ints[i] + ", " + ints[i + 1]);
}