Console.Clear();
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
Console.WriteLine("Введите целое, число: ");
int A = Convert.ToInt32(Console.ReadLine());
A = Math.Abs(A);
int result = 0;
int B = 0;
while (A > 0)
{
    B = A % 10;
    A /= 10;
    result = B + result;
}
Console.WriteLine("Сумма цифр равна: " + result);