Console.Clear();
Console.WriteLine("Программа определяет наибольшее целое число из двух");
Console.WriteLine("Введите первое, целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе, целое число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Наибольшее число: " + a );
}
else
{
    Console.WriteLine("Наибольшее число: " + b);
}