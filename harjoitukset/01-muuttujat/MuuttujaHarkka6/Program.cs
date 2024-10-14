int a, b, c;

a = 12;
b = a * 4;
a = 25;
c = (b + a) / a;
double d = (b + a) / (double)a;

Console.WriteLine(d);
Console.WriteLine(c);
// pitäisi olla 2,92
