Console.Clear();
Console.WriteLine("Программа, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y).");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 4)
{
    Console.WriteLine("Ошибка. Значение не может быть меьше 1 и больше 4, введите номер четверти: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 1)
    Console.WriteLine("x и y > 0");
else if (a == 2)
    Console.WriteLine("x < 0 и y > 0");
else if (a == 3)
    Console.WriteLine("x < 0 и y < 0");
else
    Console.WriteLine("x > 0 и y < 0");