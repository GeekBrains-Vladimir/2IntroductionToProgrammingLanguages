// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


void Result(double K1, double B1, double K2, double B2)
{
    double X = 0;
    double Y = 0;
    X = (B2 - B1) / (K1 - K2);
    Y = K1 * X + B1;
    Console.WriteLine($"Прямые пересекаются в координатах: X = {X}, Y = {Y}");
}
Console.Clear();
Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите K1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите К2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
Result(K1, B1, K2, B2);