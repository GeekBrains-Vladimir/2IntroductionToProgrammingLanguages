Console.Clear();
int n = new Random().Next(10, 100); // ???
int n1 = n / 10;
int n2 = n % 10;
Console.WriteLine($"Сгенерированное число: {n}");

if (n1 > n2)
Console.WriteLine(n1);
else if (n1 < n2)
Console.WriteLine(n2);
else
Console.WriteLine("=");
