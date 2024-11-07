float[] lukuja = [1.1f, 2.2f, 3.3f];

// 2.1 for
float summa = 0f;
// for (int i = 0; i < lukuja.Length; i++)
// {
//     summa = summa + lukuja[i];
// }

// 2.2 while
// summa = 0f;
// int idx = 0;
// while (idx < lukuja.Length)
// {
//     summa += lukuja[idx];
//     idx++;
// }

// 2.3 foreach
summa = 0f;
foreach (float luku in lukuja)
{
    summa += luku;
}

Console.WriteLine(summa);
