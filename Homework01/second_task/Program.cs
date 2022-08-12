// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;
if (num_2 > max)
{
max = num_2;
}
if (num_3 > max)
{
max = num_3;
}
Console.WriteLine(max + " Максимальное из введённых чисел");