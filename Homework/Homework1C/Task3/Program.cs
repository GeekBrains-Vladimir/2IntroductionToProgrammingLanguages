Console.Clear();
Console.WriteLine("Программа определяет является число чётным или нет");
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine("Введённое Вами число " + a + " является чётным");
else Console.WriteLine("Введённое Вами число " + a + " НЕ чётное");