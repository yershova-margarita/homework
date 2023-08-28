// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] PointXY(double b1, double k1, double b2, double k2, int size = 2)
{
    double[] array = new double[size];
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    array[0] = Math.Round(x, 1);
    array[1] = Math.Round(y, 1);
    return array;
}
Console.WriteLine("Введите b1: ");
double userB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double userK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double userB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double userK2 = Convert.ToDouble(Console.ReadLine());

if ((userK1 == userK2) && (userB1 == userB2))
{
    Console.WriteLine("Прямые совпадают");
    return;
}
if (userK1 == userK2) Console.WriteLine("Прямые параллельны");
else
{
    double[] userArray = PointXY(userB1, userK1, userB2, userK2);
    Console.WriteLine($"Точка пересечения прямых: ({userArray[0]}, {userArray[1]})");
}