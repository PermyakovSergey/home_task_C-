// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenArray(int size, int min, int max)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().Next(min, max + 1) + new Random().NextDouble(), 2);
    }
    Console.WriteLine(string.Join(", ", arr));
    return arr;
}
void DiffMinMaxValues(double[] array)
{
    double minvalue = array[0];
    double maxvalue = array[0];
    double diffvalue = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minvalue) minvalue = array[i];
        if (array[i] > maxvalue) maxvalue = array[i];
    }
    diffvalue = maxvalue - minvalue;
    Console.Write($"Maximum value = {maxvalue}, ");
    Console.WriteLine($"Minimum value = {minvalue}");
    Console.WriteLine($"Difference between the maximum and minimum values = {diffvalue}");
}

Console.WriteLine("Please enter a size of massive: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter minimum value of massive: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter maximum value of massive: ");
int max = int.Parse(Console.ReadLine());
double[] array = GenArray(size, min, max);
DiffMinMaxValues(array);