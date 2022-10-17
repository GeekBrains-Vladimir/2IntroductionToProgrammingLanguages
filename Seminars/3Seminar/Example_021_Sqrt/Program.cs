Console.Clear();
Console.WriteLine("Программа, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 2D пространстве");
Console.WriteLine("Введите координаты X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());

// double X = Math.Pow((X2 - X1), 2);
// double Y = Math.Pow((Y2 - Y1), 2);
// double L = Math.Sqrt(X + Y);
//double L1 = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)));

// Console.WriteLine(L);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2))), 3)}");