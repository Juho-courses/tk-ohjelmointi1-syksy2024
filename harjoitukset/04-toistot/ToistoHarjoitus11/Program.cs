Console.Write("Montako sanaa syötät: ");
int required_count = int.Parse(Console.ReadLine());

int sum = 0;

int count = 0;
string word;
while (count < required_count)
{
    Console.Write("Sana: ");
    word = Console.ReadLine();
    if (word == "") { continue; }
    count++;
    sum += word.Length;
}

Console.WriteLine("Yhteenlaskettu pituus " + sum);