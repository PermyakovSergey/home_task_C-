// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int GetSumOfRowElements(int[,] arr, int indexOfRow)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[indexOfRow, j];
    }
    return sum;
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

int indexOfMinRow = 0;
int minSumNumbers = GetSumOfRowElements(array, indexOfRow: 0);
int[] arrayForResult = new int[array.GetLength(0)];
for (int i = 1; i < array.GetLength(0); i++)
{
    int sumNextRow = GetSumOfRowElements(array, i);
    if (sumNextRow < minSumNumbers)
    {
        indexOfMinRow = i;
        minSumNumbers = sumNextRow;
    }
}
Console.WriteLine("First row found with the minimum sum of elements: " + (indexOfMinRow + 1));
