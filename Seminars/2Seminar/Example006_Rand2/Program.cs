Console.Clear();
int n = new Random().Next(1, 1000);
//int n1 = new Random().Next(1, 10);                   обманка :-)
// int n2 = new Random().Next(1, 10);
// int n3 = new Random().Next(1, 10);
// Console.WriteLine("Случайное число: " + n1 + n2 + n3);
// Console.WriteLine("Первое и второе значение: " + n1 + n3);
Console.WriteLine(n);
int n1 = n / 100;
int n2 = n % 10;
Console.WriteLine(n1 * 10 + n2);

// Console.Clear();                             альтернатива 
// int n = new Random().Next(100, 1000);
// Console.WriteLine($"{n}\n{n / 100 * 10 + n % 10}");    // \n - переход на новую строку