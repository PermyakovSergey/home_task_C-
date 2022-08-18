// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SummOfNumbers(int number)
{
    int summ = 0;
    while (number > 0 && number > 9)
    {
        summ = summ + number % 10;
        number = number / 10;
    }
    summ = summ + number;

    Console.WriteLine("сумма цифр в числе: " + summ);
}

Console.Write("Введите число, программа выведет сумму цифр в числе: ");
int number = int.Parse(Console.ReadLine());
SummOfNumbers(number);


