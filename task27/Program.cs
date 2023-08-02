/*
Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

bool ValidateNum(int num)
{
    if (num < 0)
    {
        Console.WriteLine($"Число {num} не является натуральным, повторите ввод");
        return false;
    }
    else return true;
}

Console.WriteLine("Введите число :");
int userNum = Convert.ToInt32(Console.ReadLine());

if (ValidateNum(userNum)) Console.WriteLine($"Сумма цифр числа {userNum} : {SumDigit(userNum)}");