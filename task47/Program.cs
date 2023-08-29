// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateRndMatrixDouble(int rows, int cols, int min, int max)
{
    double[,] matrix = new double[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = min + rnd.NextDouble() * (max - min);
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j], 6}");
		}
		Console.WriteLine(" |");
		Console.WriteLine();
	}
}

int userRows = ReadInt("Введите количество строк: ");
int userCols = ReadInt("Введите количество столбцов: ");
int userMin = ReadInt("Введите минимальное число для заполнения матрицы: ");
int userMax = ReadInt("Введите максимальное число для заполнения матрицы: ");

double[,] array2d = CreateRndMatrixDouble(userRows, userCols, userMin, userMax);
PrintMatrix(array2d);