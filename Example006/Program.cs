int a = 12;
int b = 2;
int c = 6;
int d = 22;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("Максимально число = ");
Console.WriteLine(max);
