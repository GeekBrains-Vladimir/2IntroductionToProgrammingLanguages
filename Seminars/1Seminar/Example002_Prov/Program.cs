Console.WriteLine("Программа проверяет, является ли первое число квадратом второго");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("Первое число ЯВЛЯЕТСЯ кватратом второго");
}
else
{
Console.WriteLine("Первое число НЕ является кватратом второго");    
}