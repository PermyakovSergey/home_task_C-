// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

void RandomMassive(int number, int min, int max)
{
    if (number <= 0)
    {
        Console.WriteLine("Количество элементов массива должно быть больше нуля!");
        return;
    }
    Console.WriteLine("Массив целых случайных чисел с заданными значениями:");
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
        Console.WriteLine("Минимальное и максимальное значение было переставлено!:");
    }
    max = max + 1;
    int[] massive = new int[number];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(min, max);
        Console.Write(massive[i] + " ");
    }
    
}
RandomMassive(number, min, max);
