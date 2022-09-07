// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m,
    n;
Console.WriteLine("Введите число M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
n = Convert.ToInt32(Console.ReadLine());

int SumRange(int m, int n)
{
    int sum = 0;
    if (m < n)
        sum = m + n + SumRange(m + 1, n - 1);
    else if (m == n)
        sum = n;
    return sum;
}
Console.WriteLine("Сумма натуральных чисел в данном диапазоне");
Console.WriteLine(SumRange(m, n));
