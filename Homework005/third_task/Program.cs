// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomarray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < array.Length; n++)
{
    if (array[n] > max)
        {
            max = array[n];
        }
    if (array[n] < min)
        {
            min = array[n];
        }
}

Console.WriteLine($"Массив из {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomarray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] array)
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