/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/

void cubesTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.WriteLine($"{i,5} {cube,7}"); //форматирование вывода
    }
}

Console.WriteLine("Введите науральное число : ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum < 1)
{
    Console.WriteLine("Вы ввели не натуральное число, повторите ввод");
}
cubesTable(userNum);