Console.Clear();
Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
Console.WriteLine("Введите целое, число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Дружище, сказали же от 1 до 7, давай заново: ");
    a = Convert.ToInt32(Console.ReadLine());
}
while (a >= 1 && a <= 5)
{
    Console.WriteLine("Дружище, бери лопату, копай от меня и до выходных. Сегодня - РАБОЧИЙ ДЕНЬ!");
    break;
}
while (a >= 6 && a <= 7)
{
    Console.WriteLine("Гуляй, Рванина - ВЫХОДНОЙ!");
    break;
}