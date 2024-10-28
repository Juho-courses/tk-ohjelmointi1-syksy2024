// int[] ints = new int[5];
// Console.WriteLine(ints[1]);

// ints[1] = 123;
// Console.WriteLine(ints[1]);

// ints[0] += 6; // ints[0] = ints[0] + 6
// Console.WriteLine(ints[1]);

string ekasana = "moi";
string[] sanat = { ekasana, "SAMK", "Pori", "Kolme" };

Console.WriteLine(sanat[0] + ", " + sanat[1] + ", " + sanat[2] + ", " + sanat[3]);

Console.WriteLine(sanat.Length);
Console.WriteLine(sanat[3]);
Console.WriteLine(sanat[sanat.Length - 1]);

Console.WriteLine(sanat.Last());
Console.WriteLine(sanat.First());