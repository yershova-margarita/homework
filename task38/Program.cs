/*
 Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{roundNum}; ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double MaxElemArray(double[] arr, int round = 1)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return Math.Round(max, round);
}

double MinElemArray(double[] arr, int round = 1)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return Math.Round(min, round);
}

double DiffMaxMin(double max, double min, int round = 1)
{
    double diff = max - min;
    return Math.Round(diff, round);
}

double[] array = CreateArrayRndDouble(12, 1, 10);
PrintArrayDouble(array);
double elMax = MaxElemArray(array);
double elMin = MinElemArray(array);
double elDiff = DiffMaxMin(elMax, elMin);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива = {elMax}");
Console.WriteLine($"Минимальный элемент массива = {elMin}");

Console.WriteLine($"Разница между максимальным и минимальным числом = {elDiff}");