// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");

string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - Является палиндромом.");
  }
  else 
  Console.WriteLine($"Число: {number} - Не является палиндромом.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else 
Console.WriteLine($"Введи пятизначное число!");