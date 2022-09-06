// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void ShowSumNumbersBetween(int result, int initial, int final)
{
    result += initial;
    initial++;
    if (initial <=final) ShowSumNumbersBetween(result, initial, final);
    else Console.Write(result);
}
int sum = 0;
int m = 1;
int n = 15;
ShowSumNumbersBetween(sum, m, n);