int age = int.MaxValue;

// age = 23;

Console.WriteLine(age);


float pi = 3.14f;

// double pi2 = 3.14;
Console.WriteLine(pi);

string name = "samk";
string rnd_str = " on koulu";

Console.WriteLine(name + rnd_str);
Console.WriteLine($"{name}{rnd_str}");
Console.WriteLine("{name}{rnd_str}");

bool isAlive = true; // false
isAlive = false;
Console.WriteLine(isAlive);

// ei toimi, koska tyyppiyhteensopivuus
// isAlive = 1;

char c = 'd';