// Функции, процедура

Console.Clear();
void f(ref int x, int y=0) // процедура
{
x = x + 10;
}


int n = 5;
Console.WriteLine(n);
f(ref n);
Console.WriteLine(n);
// Сколько значений мы передаем, столько мы и принимаем
// Сколько значений мы принимаем, столько мы и передаем