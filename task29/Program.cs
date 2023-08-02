/*
Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

int[] CreateArray(int min, int max)
{
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

bool ValidateRange(int min, int max)
{
    if (min > max) 
    {
        Console.WriteLine("Минимальное значение не может быть больше максимального, повторите ввод");
        return false;
    }
    return true;
}

void PrintArray(int[] arr)
{
    Console.Write("Сгенерированный массив : [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите минимальное число для диапазона :");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число для диапазона :");
int userMax = Convert.ToInt32(Console.ReadLine());

if (ValidateRange(userMin, userMax))
{
    int[] userArray = CreateArray(userMin, userMax);
    PrintArray(userArray);
}