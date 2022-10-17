Console.Clear();
Console.WriteLine("Программа, которая принимает на вход координаты точки (X и Y), причём X и Y не равны 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");
Console.WriteLine("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0 || y == 0)
{
    Console.WriteLine("Ошибка. Значение не может быть равным 0, введите X и Y: ");
    x = Convert.ToDouble(Console.ReadLine());
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");