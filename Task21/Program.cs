// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты первой точки x: ");
int num1X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y: ");
int num1Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки z: ");
int num1Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки x: ");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки y: ");
int num2Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки z: ");
int num2Z = Convert.ToInt32(Console.ReadLine());


double result = Distance(num1X, num1Y, num1Z, num2X, num2Y, num2Z);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;
double c = Math.Sqrt(x*x+y*y+z*z);
return c;
}