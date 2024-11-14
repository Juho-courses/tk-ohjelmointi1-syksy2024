Console.Write("Syötä sana: ");
string sana = Console.ReadLine();

string reversed = "";
// reversed = string.Join(",", sana.ToArray().Reverse());

for (int i = sana.Length - 1; i >= 0; i--)
{
    reversed += sana[i];
}

if (sana == reversed)
{
    Console.WriteLine("jep");
}
else
{
    Console.WriteLine("ei palindrome");
}