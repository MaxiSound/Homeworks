// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int n = 8;
int min = 0;
int max = 999;

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
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
}
PrintArray(array);
