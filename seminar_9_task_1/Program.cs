// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void PrintNumbers(int startNumber, int finishNumber)
{

    Console.Write(startNumber + " ");
    startNumber++;
    if (startNumber <= finishNumber) PrintNumbers(startNumber, finishNumber);
}
int m = 4;
int n = 8;
PrintNumbers(m, n);