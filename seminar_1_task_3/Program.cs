﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Напишите число, я выдам является ли число чётным");

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("да");
if (number % 2 != 0)
    Console.WriteLine("нет");