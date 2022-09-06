// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Произведением двух матриц А и В называется матрица С, элемент которой, 
// находящийся на пересечении i -й строки и j -го столбца, 
// равен сумме произведений элементов i -й строки матрицы А на соответствующие (по порядку) 
// элементы j -го столбца матрицы В. Из этого определения следует формула элемента матрицы C: 
// Произведение матрицы А на матрицу В обозначается АВ.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
int[,] ProductMatrix(int[,] matrA, int[,] matrB)
{
    int[,] resultAB = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < resultAB.GetLength(0); i++)
    {
        for (int j = 0; j < resultAB.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < resultAB.GetLength(1); k++)
            {
                summ += (matrA[i, k] * matrB[k, j]);
            }
            resultAB[i, j] = summ;
        }
    }
    return resultAB;
}
int size = 2;
int[,] matrixFirst = new int[size, size];
FillArray(matrixFirst);
PrintArray(matrixFirst);
Console.WriteLine();

int[,] matrixSecond = new int[size, size];
FillArray(matrixSecond);
PrintArray(matrixSecond);
Console.WriteLine();

int[,] matrixProduct = ProductMatrix(matrixFirst, matrixSecond);
PrintArray(matrixProduct);