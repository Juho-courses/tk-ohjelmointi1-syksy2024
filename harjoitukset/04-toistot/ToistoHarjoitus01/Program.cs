string[] sanat = ["ohjelmointi", "on", "kivaa"];

// 1.1
// foreach (string sana in sanat)
// {
//     Console.WriteLine(sana);
// }

// 1.2
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine(i + ": " + sanat[i]);
// }

int idx = 0;
while (idx < 3)
{
    Console.WriteLine(sanat[idx]);
    idx++;
}