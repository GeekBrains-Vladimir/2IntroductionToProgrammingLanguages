Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
Console.WriteLine("кратно");
else
Console.WriteLine($"не кратно, остаток {n % m}");