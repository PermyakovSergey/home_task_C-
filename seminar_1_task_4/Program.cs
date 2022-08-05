//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число > 1, я выдам все чётные числа от 1 до N");

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;
if (number <= 1)
    Console.WriteLine("неверное число");
while (count < number - 1)
    {count += 2;
    Console.WriteLine(count);}
