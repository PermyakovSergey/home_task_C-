// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine(string.Join(",", arr));
    return arr;
}

void SummOddNumbers(int[] array)
{
    int summoddnumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) summoddnumbers += array[i];
    }
    Console.WriteLine($"The summ of odd numbers in the array: = {summoddnumbers}");
}
Console.WriteLine("Please enter a size of massive: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter minimum value of massive: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter maximum value of massive: ");
int max = int.Parse(Console.ReadLine());
int[] array = GenArray(size, min, max);

SummOddNumbers(array);