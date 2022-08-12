// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
    if (i % 2 != 1)
    {
    Console.Write(i + ", ");
    }
i++;
}
if (i <= 1)
{
Console.WriteLine("Чётных чисел не найдено!");
}