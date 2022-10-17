Console.Clear();
Console.Write("Введите число: ");
//string n = Convert.ToString(Console.ReadLine());
//Console.WriteLine(n.Length);
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (n > 0)
{
    n /= 10; //n = n/10
    result++;
}
Console.WriteLine(result);