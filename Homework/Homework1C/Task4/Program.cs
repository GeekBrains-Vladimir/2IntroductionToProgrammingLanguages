Console.Clear();
Console.WriteLine("Программа показывает все чётные числа от 1 до введёного Вами числа");
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
//for (int i=2; i<a; i=i+2)
//    Console.Write(i + " ");
Console.Write("Чётные числа в диапазоне от 1 до " + a + ": ");
while (i<=a)
{
    if(i%2==0)
    Console.Write(i+ " ");
    i++;
}