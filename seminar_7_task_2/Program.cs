// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] GenRandomArray()
{
    int[,] randomarray = new int[3, 4];
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            randomarray[i, j] = new Random().Next(0, 11);
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
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void FindNumberInArray(int[,] arr) // Метод выводит индексы всех найденных значений
{
    Console.Write("For searching in the array ");
    int numberfind = CheckInputIfNotNumber();
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == numberfind)
            {
                Console.WriteLine($"The number {numberfind} was found in the position with the index [{i}, {j}] ");
                count++;
            }
        }
    }
    if (count == 0) {Console.WriteLine($"The number {numberfind} is not in the array");}
}

Console.WriteLine("An array of numbers is given");
int[,] array = GenRandomArray();
PrintArray(array);
FindNumberInArray(array);
