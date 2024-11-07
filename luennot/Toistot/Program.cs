// for (int i = 20; i >= 0; i--)

// {
//     Console.WriteLine(i);
// }

// int[] nums = { 1, 2, 3, 4, 5, 6, 7, 9, 123, 321 };

// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] == 4)
//     {
//         continue;
//     }
//     Console.Write(nums[i] + " ");
// }

// int count = 0;
// while (count < 3)
// {
//     Console.WriteLine(count);
//     count++;
// }

string[] sanat = ["ohjelmointi", "on", "kivaa"];

foreach (var sana in sanat)
{
    Console.WriteLine(sana);
    continue;
}
