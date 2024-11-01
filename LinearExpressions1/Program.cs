double a, b, c, d;

Console.Write("Enter a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter d: ");
d = Convert.ToDouble(Console.ReadLine());

double x = (a + 2 * b - c + d) / c / d + (a + b) / (c - d) - a * a / b / b;
Console.WriteLine("x = {0}", x);

double y = 5 * (a + b) * (c - d) / (1f / 2) * c + d * d * (a * a - b * b) / (b - a);
Console.WriteLine("y = {0}", y);

double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
Console.WriteLine("z = {0}", z);

double r = (1f / 2 * a + 3f / 4 * b - 7f / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine("r = {0}", r);
