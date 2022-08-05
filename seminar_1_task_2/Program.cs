//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Напишите три числа, я выдам какое из них максимальное(max)");

Console.Write("введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("введите третье число: ");
double c = double.Parse(Console.ReadLine());

double max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);