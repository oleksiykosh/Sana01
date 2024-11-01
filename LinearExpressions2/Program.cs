double a, b, m, n, x;

Console.Write("Enter m: ");
m = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter n: ");
n = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x: ");
x = Convert.ToDouble(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
Console.WriteLine("z1 = {0}", z1);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("z2 = {0}", z2);
double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
Console.WriteLine("y = {0}", y);
