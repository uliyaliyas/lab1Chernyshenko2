Console.WriteLine("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите h:");
double h = double.Parse(Console.ReadLine());
double s1 = a * a;
double s2 = b * b;
double v = h * (s1 + Math.Sqrt(s1 * s2) + s2) / 3; Console.WriteLine("Объем усеченной пирамиды:" + v);
