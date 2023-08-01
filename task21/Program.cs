/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance(double x1, double y1, double z1, double x2, double y2, double z2) 
{
    double sqrt = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return Math.Round(sqrt, 2, MidpointRounding.ToZero);
}
Console.WriteLine("Введите координаты первой точки :");
Console.Write("x1 = ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки :");
Console.Write("x2 = ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double userDistance = Distance(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
Console.WriteLine($"Расстояние между точками : {userDistance}");