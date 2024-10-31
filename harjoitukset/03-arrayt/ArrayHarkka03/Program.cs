// Console.Write("Kirjoita sana: ");
// string sana1 = Console.ReadLine();

// Console.Write("Kirjoita sana: ");
// string sana2 = Console.ReadLine();

// Console.Write("Kirjoita sana: ");
// string sana3 = Console.ReadLine();

// string[] sanat = { sana1, sana2, sana3 };

// -------------------

string[] sanat = new string[3];

Console.Write("Kirjoita sana: ");
string sana = Console.ReadLine();
sanat[0] = sana;

Console.Write("Kirjoita sana: ");
sana = Console.ReadLine();
sanat[1] = sana;

Console.Write("Kirjoita sana: ");
sana = Console.ReadLine();
sanat[2] = sana;


Console.WriteLine(sanat[2]);
Console.WriteLine(sanat[1]);
Console.WriteLine(sanat[0]);