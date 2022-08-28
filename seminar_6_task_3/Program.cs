// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int CheckInputForArr()
{
    Console.Write("it must be number > 0: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.Write("Value can't be text, ");
        return CheckInputForArr();
    }
    if (number == 0 || number < 0)
    {
        Console.Write("Value can't be negative or zero, ");
        return CheckInputForArr();
    }
    return number;
}

int[,] GenRandomArray(int rows, int columns)
{
    int[,] randomarray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomarray[i, j] = new Random().Next(-10, 11);
        }
    }
    return randomarray;
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

void SumElementsOfMainDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i, j];
                Console.WriteLine($"Element with index [{i}, {j}] = {arr[i, j]} ");
            }
        }
    }
    Console.WriteLine($"The sum of the elements of the main diagonal = {sum}");
}

Console.Write("Enter the number of rows in the array, ");
int r = CheckInputForArr();
Console.Write("Enter the number of columns in the array, ");
int c = CheckInputForArr();
int[,] array = GenRandomArray(r, c);
PrintArray(array);
SumElementsOfMainDiagonal(array);
