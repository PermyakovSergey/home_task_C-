// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter the coordinates of the straight lines");
Console.Write("Enter the coordinate b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Enter the coordinate k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Enter the coordinate b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Enter the coordinate k2: ");
double k2 = int.Parse(Console.ReadLine());
// для нахождения значения по оси абсцисс правые части уравнений прямых приравниваем:
// k1 * x + b1 = k2 * x + b2    ->     x = (b2 - b1) / (k1 - k2);
double x = Math.Round((b2 - b1) / (k1 - k2), 2);
// для нахождения значения по оси ординат, подставляем значение х в уравнение любой прямой:
double y = Math.Round(k1 * x + b1, 2);
Console.WriteLine($"Coordinates of the intersection point (x; y) = ({x}; {y})");



