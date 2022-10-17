Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = (-1) * n; i <= n; i++) // i = i + 1 <=> i++
Console.Write(i + " ");