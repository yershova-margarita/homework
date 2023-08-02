/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int PowerNumber(int a, int b)
{
    int productNum = 1;
    for (int i = 1; i <= b; i++)
    {
        productNum *= a;
    }
    return productNum;
}

bool ValidateB(int b)
{
    if (b < 0)
    {
        Console.WriteLine("Показатель степень не может быть отрицательным, повторите ввод");
        return false;
    }
    else return true;
}
Console.WriteLine("Введите число А");
int userA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B");
int userB = Convert.ToInt32(Console.ReadLine());

if (ValidateB(userB))
{
    int userProdNum = PowerNumber(userA, userB);
    Console.WriteLine($"Число {userA} в степени {userB} = {userProdNum}");
}