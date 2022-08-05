//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите два числа, я выдам какое из них большее(max), а какое меньшее(min)");

Console.Write("введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("введите второе число: ");
double b = double.Parse(Console.ReadLine());

if (a > b){Console.Write("max = "); Console.WriteLine(a);
Console.Write("min = "); Console.WriteLine(b);}
else {Console.Write("max = "); Console.WriteLine(b);
Console.Write("min = "); Console.WriteLine(a);}

//В условии задачи прописано чтобы программа выдавала так же меньшее число

