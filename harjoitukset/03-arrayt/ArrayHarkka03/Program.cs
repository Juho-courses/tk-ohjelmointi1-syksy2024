// // Kysy käyttäjältä sanat
// Console.Write("Kirjoita sana: ");
// string sana1 = Console.ReadLine();

// Console.Write("Kirjoita sana: ");
// string sana2 = Console.ReadLine();

// Console.Write("Kirjoita sana: ");
// string sana3 = Console.ReadLine();

// // Luo uusi taulokko syötetyistä arvoista
// string[] sanat = { sana1, sana2, sana3 };

// -------------------

// // Luo uusi taulukko
string[] sanat = new string[3];

// Kysy sanat ja tallenna ne taulukkoon
Console.Write("Kirjoita sana: ");
string sana = Console.ReadLine();
sanat[0] = sana;

Console.Write("Kirjoita sana: ");
sana = Console.ReadLine();
sanat[1] = sana;

Console.Write("Kirjoita sana: ");
sana = Console.ReadLine();
sanat[2] = sana;


// Tulostetaan sanat käänteisessä järjestyksessä
Console.WriteLine(sanat[2]);
Console.WriteLine(sanat[1]);
Console.WriteLine(sanat[0]);
