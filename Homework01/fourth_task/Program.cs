// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Чётные числа от 1 до " + number);

if (number > 1)
    while (i <= number)
{
    if (i % 2 == 0)
    {
    Console.Write(i + ", ");
    }
    i++;
}
if (number <= 1)
{
    Console.WriteLine("Чётных чисел не найдено");
}