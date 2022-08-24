// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int count = 0;

for (int n = 0; n < array.Length; n++)
{
    if (array[n] % 2 == 0)
        count++;
}

Console.WriteLine($"Массив из {array.Length} чисел, {count} из них чётных");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    Console.Write("[ ");
    while (index < count)
    {
        Console.Write(array[index]);
        index++;

        if (index < count)
        {
            Console.Write(" | ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}
