// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int FindMaxElement(int[,] arr, int rowInd, int colInd, int maxEl)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[rowInd, j] > maxEl)
        {
            maxEl = arr[rowInd, j];
        }
    }
    return maxEl;
}

void SortRowsOfArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int x = j + 1; x < arr.GetLength(1); x++)
            {
                if (arr[i, x] > arr[i, maxPosition])
                {
                    maxPosition = x;
                }
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, maxPosition];
            arr[i, maxPosition] = temp;
        }
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortRowsOfArray(array);
PrintArray(array);





