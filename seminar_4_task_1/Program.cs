// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double degree(double x, int y)
{
    double result = x;
    for (int i = 1; i < y; i++)
    {
        result = result * x;
    }
    return result;
}
Console.WriteLine("Введите два числа, первое будет возведено в степень равную второму числу");
Console.Write("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равно: {degree(a, b)}");
