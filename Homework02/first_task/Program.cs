﻿// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    number = number % 100 / 10;
    Console.WriteLine("Вторая цифра введённого числа: " + number);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число, попробуй ещё раз!");
}