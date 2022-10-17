Console.Clear();
Console.WriteLine("Введите количество кустов от 3-х до 1000: ");
//int[] Mass = new int[int.Parse(Console.ReadLine())];
int n = Convert.ToInt32(Console.ReadLine());
int[] Mass = new int[n];
int N = Mass.Length;
if (N > 2 && N < 1001)
{
    int Max = 1;
    int Sum = 1;
    int i = 0;
    int S = 0;
    Console.WriteLine("Собираем чернику");
    var random = new Random();
    for (int j = 0; j < N; j++)
    {
        Mass[j] = random.Next(1, (1000 / N) + 1);
        S += Mass[j];
    }
    Console.WriteLine("Количество ягод на каждом кусту: {0} ", String.Join(" ", Mass));
    Console.WriteLine($"Общее количество ягод: {S}");
    Sum = Mass[i] + Mass[(N - 1)] + Mass[(N - 2)];
        if (Sum > Max)
            Max = Sum;
    i++;
    Sum = Mass[i] + Mass[i - 1] + Mass[N - 1];
        if (Sum > Max)
            Max = Sum;
    i++;
    for (i = 2; i < N; i++)
    {
        Sum = Mass[i] + Mass[i - 1] + Mass[i - 2];
        if (Sum > Max)
            Max = Sum;
    }
    Console.WriteLine($"Максимальное число ягод, которое может собрать за один заход собирающий модуль: {Max}");
}
else
{
    Console.WriteLine("ОШИБКА! Запускай прогу заново. Кустов должно быть от 3-х до 1000: ");
}