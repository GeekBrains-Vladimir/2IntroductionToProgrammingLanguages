Console.Clear();
Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
Console.WriteLine("Введите целое, трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.WriteLine("Вы ошиблись! Введите целое, трёхзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
//int b = a / 10;
//int c = b % 10;
Console.WriteLine($"Вторая цифра Вашего трёхзначного числа равна: {(a / 10) % 10}");