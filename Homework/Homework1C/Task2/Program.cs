Console.Clear();
Console.WriteLine("Программа определяет наибольшее целое число из трёх");
Console.WriteLine("Введите первое, целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе, целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье, целое число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    Console.WriteLine("Наибольшее число: " + a );
else Console.WriteLine("Наибольшее число: " + c );
}
else
{
    if (b > c)
    Console.WriteLine("Наибольшее число: " + b );
    else Console.WriteLine("Наибольшее число: " + c);
}