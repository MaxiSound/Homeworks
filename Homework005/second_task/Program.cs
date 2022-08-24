// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int sum = 0;

for (int n = 1; n < array.Length; n += 2)
    sum = sum + array[n];

Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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