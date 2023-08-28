// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PointX(int k1, int k2, int b1, int b2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    return x;
}

double PointY(double x, int k2, int b2)
{
    double[] array = new double[2];
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    // double x = 0.5;
    // double y = 0.5;
    array[0] = Math.Round(x, 1);
    array[1] = Math.Round(y, 1);
    return array;
}

// Console.WriteLine("Введите b1: ");
// int userB1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// int userK1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// int userB2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// int userK2 = Convert.ToInt32(Console.ReadLine());

// if ((userK1 == userK2) && (userB1 == userB2))
// {
//     Console.WriteLine("Прямые совпадают");
//     return;
// }
// if (userK1 == userK2) Console.WriteLine("Прямые параллельны");
// else
// {
//     Console.WriteLine($"Точка пересечения {PointXY(userK1, userK2, userB1, userB2)}");
// }
Console.WriteLine($"Точка пересечения {PointXY(2, 5, 4, 9)}");