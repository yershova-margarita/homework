// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    else
    {
        m++;
        res = m + SumNaturalNumbers(m, n);
        return res;
    }
}

void PrintSumNaturalNumbers(int m, int n)
{
    Console.WriteLine($"Cумма от {m} до {n} = {SumNaturalNumbers(m - 1, n)}");
}

Console.WriteLine("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

if (userM < 1 || userN < 1)
{
    Console.WriteLine("Не корректный ввод: ");
    return;
}
PrintSumNaturalNumbers(userM, userN);