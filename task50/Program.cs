// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

void ReturnElemMatrix(int rows, int cols, int[,] matrix)
{
    if (rows < matrix.GetLength(0) && cols < matrix.GetLength(1)) Console.WriteLine($"Значение элемента на позиции ({rows}, {cols}) : {matrix[rows, cols]}");
    else Console.WriteLine($"Упс! А позиции ({rows}, {cols} нет этой в матрице");
}

Console.WriteLine("Приветствую! А давайте создадим матрицу :)");
int userRows = ReadInt("Сначала введите количество строк: ");
int userCols = ReadInt("Прекрасно! А теперь введите количество столбцов: ");
int userMin = ReadInt("Вы на верном пути! Введите минимальное число для заполнения матрицы: ");
int userMax = ReadInt("Еще чуть-чуть ... Введите максимальное число для заполнения матрицы: ");

int[,] array2d = CreateMatrixRndInt(userRows, userCols, userMin, userMax);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Вы великолепны! Давайте найдем элемент в матрице:");
int indRows = ReadInt("Введите индекс строки: ");
int indCols = ReadInt("Введите индекс столбца: ");
ReturnElemMatrix(indRows, indCols,array2d);
