// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 

double distanse3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

Console.WriteLine("Введите кординаты двух точек для нахождения расстояния между ними в 3D пространстве.");
Console.WriteLine("Введите три координаты первой точки через ENTER: ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
double za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите три координаты второй точки через ENTER: ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());
double zb = double.Parse(Console.ReadLine());

double result = Math.Round(distanse3D(xa, ya, za, xb, yb, zb), 2);
Console.WriteLine("Расстояние между точками: " + result);
