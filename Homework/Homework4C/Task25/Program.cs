Console.Clear();
Console.WriteLine("Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
Console.WriteLine("Введите целое, число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое, число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for (int i = 0; i < B; i++)
    C = C * A;
Console.WriteLine("Число " + A + " в степени " + B + " равно: " + C);