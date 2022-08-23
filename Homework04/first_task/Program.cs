// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

  Console.WriteLine("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++) // Вот начало цикла по условию задачи
  {
    result = result * numberA;
  }
    return result;               // вот конец цикла по условию задачи
}
  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: ");
  Console.Write(exponentiation);