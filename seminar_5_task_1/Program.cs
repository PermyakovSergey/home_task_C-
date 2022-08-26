// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
    Console.WriteLine(string.Join(",", arr));
    return arr;
}
void SearchEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Number of even numbers in the array: = {count}");
}

Console.WriteLine("Please enter a size of massive: ");
int size = int.Parse(Console.ReadLine());

int[] array = GenArray(size);
SearchEvenNumbers(array);