// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int m,
    n;
Console.WriteLine("Введите число M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
n = Convert.ToInt32(Console.ReadLine());

void PrintRange(int m, int n)
{
    if (n > m)
    {
        PrintRange(m, n - 1);
        Console.Write(", ");
    }
    Console.Write(n);
}
Console.WriteLine("Натуральные числа в данном диапазоне: ");
PrintRange(m, n);
