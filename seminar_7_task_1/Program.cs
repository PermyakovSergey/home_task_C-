// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int CheckInputForArraySize()
{
    Console.Write("it must be number > 0: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.Write("Value can't be text, ");
        return CheckInputForArraySize();
    }
    if (number == 0 || number < 0)
    {
        Console.Write("Value can't be negative or zero, ");
        return CheckInputForArraySize();
    }
    return number;
}

int CheckInputIfNotNumber()
{
    Console.Write("enter a number: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.Write("Value can't be text, ");
        return CheckInputIfNotNumber();
    }
    return number;
}

double[,] GenRandomArray()
{
    Console.Write("Enter the number of rows in the array, ");
    int rows = CheckInputForArraySize();
    Console.Write("Enter the number of columns in the array, ");
    int columns = CheckInputForArraySize();
    Console.Write("Enter the minimum value of elements in array: ");
    int min = CheckInputIfNotNumber();
    Console.Write("Enter the maximum value of elements in array: ");
    int max = CheckInputIfNotNumber();
    double[,] randomarray = new double[rows, columns];
    if (min > max) {int temp = min; min = max; max = temp;}
    if (min == max) 
    {Console.WriteLine("Since the entered minimum and maximum values are equal, the maximum is increased by one");}
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomarray[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
        }
    }
    return randomarray;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

double[,] array = GenRandomArray();
PrintArray(array);