// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

int m,
    n;
Console.WriteLine("Введите число M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m > 0 && n == 0)
        {
        return Akkerman(m - 1, 1);
        }
    if (m > 0 && n > 0)
        {
        return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    return n + 1;
}
Console.WriteLine("Функция Аккермана равна: ");
Console.WriteLine(Akkerman(m, n));
