// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateRndMatrixInt(int rows, int columns, int min, int max)
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

double[] AvgNumCols(int[,] matrix)
{
    double[] avgNumCols = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            result += matrix[i, j];
        }
        avgNumCols[j] = result / matrix.GetLength(1);
        avgNumCols[j] =  Math.Round(avgNumCols[j], 1);
    }
    return avgNumCols;
}

void PrintArray(double[] arr)
{
	Console.Write("Среднее арифметическое каждого столбца: ");
    Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write($"{arr[i]}");
	}
	Console.Write("]");
}

int userRows = ReadInt("Введите количество строк: ");
int userCols = ReadInt("Введите количество столбцов: ");
int userMin = ReadInt("Введите минимальное число для заполнения матрицы: ");
int userMax = ReadInt("Введите максимальное число для заполнения матрицы: ");

int[,] array2d = CreateRndMatrixInt(userRows, userCols, userMin, userMax);
PrintMatrix(array2d);
double[] avgArray = AvgNumCols(array2d);
PrintArray(avgArray);
