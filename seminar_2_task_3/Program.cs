// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number of the week day, the program will show whether this day is a weekend or not: ");
int number = int.Parse(Console.ReadLine());
switch  (number)
{
    case 1 : Console.WriteLine("Not, it's a Work Day"); break;
    case 2 : Console.WriteLine("Not, it's a Work Day"); break;
    case 3 : Console.WriteLine("Not, it's a Work Day"); break;
    case 4 : Console.WriteLine("Not, it's a Work Day"); break;
    case 5 : Console.WriteLine("Not, it's a Work Day"); break;
    case 6 : Console.WriteLine("Yes, it is a Weekend Day"); break;
    case 7 : Console.WriteLine("Yes, it is a Weekend Day"); break;
    default : Console.WriteLine("Unknown day"); break;
}