// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}

void PrintAkkermanFunction(int m, int n)
{
    Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");
}

Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

if (userM < 1 || userN < 1)
{
    Console.WriteLine("Некорректный ввод: ");
    return;
}

PrintAkkermanFunction(userM, userN);
