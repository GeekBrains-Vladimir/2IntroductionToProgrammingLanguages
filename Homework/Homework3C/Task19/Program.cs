Console.Clear();
Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите целое, пятизначное число: ");
double a = Convert.ToDouble(Console.ReadLine());
while (a < 10000 || a > 99999)
{
    Console.WriteLine("Дружище - написано пятизначное, пять циферок напиши: ");
    a = Convert.ToInt32(Console.ReadLine());
}
string str = a.ToString();
if (str[0] == str[4] && str [1] == str [3])
{
    Console.WriteLine("Да");
}
else
    Console.WriteLine("Нет");