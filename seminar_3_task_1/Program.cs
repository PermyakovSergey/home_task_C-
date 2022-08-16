// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter an integer to check if it is a palindrome or not: ");
string number = Console.ReadLine();

string mirror = string.Empty;

for (int index = 0; index < number.Length; index++)
{
    mirror = mirror + number[number.Length - index -1];
}
if (number == mirror)

Console.WriteLine("Entered integer is a palindrome");

if (number != mirror)

Console.WriteLine("Entered integer is NOT a palindrome");

// Console.Write("Enter an integer to check if it is a palindrome or not: ");
// string number = Console.ReadLine();
// string mirror = string.Empty;
// int index = 0;
// int count = number.Length;
// while (index < count)
// {
//     char temp = number[index];
//     mirror = mirror + number[number.Length - index -1];
//     index++;
// }
// if (number == mirror)

// Console.WriteLine("Entered integer is a palindrome");

// if (number != mirror)

// Console.WriteLine("Entered integer is NOT a palindrome");