// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountOfPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    Console.WriteLine($"Count of positive numbers = {count}");
}

Console.Write("Enter numbers separated by a space: ");

string str = Console.ReadLine();
string[] strArray = str.Split(' ');
int[] array = new int[strArray.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(strArray[i]);
}
Console.WriteLine(string.Join(", ", array));
CountOfPositiveNumbers(array);