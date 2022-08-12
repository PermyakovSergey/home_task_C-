// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число, программа покажет вторую цифру этого числа: ");
string number = Convert.ToString(int.Parse(Console.ReadLine()));
if (number.Length <= 2 || number.Length > 3)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    Console.WriteLine("Введено число: " + number);
    Console.WriteLine("Вторая цифра числа: " + number[1]);
}
