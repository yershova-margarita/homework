/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да
*/

/******************************************/
/*** Решение 1 (через работу со строкой)***/
/******************************************/
// bool IsPalindrome(string num)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         return true;
//     }
//     return false;
// }
// Console.WriteLine($"Введите пятизначное число :");
// // "?" добавляется , чтобы сделать переменную ссылочным типом, допускаемым значением NULL
// string? userNum = Console.ReadLine(); 

// // "!" оператор прощения значений NULL
// if (userNum!.Length != 5) {
//     Console.WriteLine($"Некорректный ввод, повторите попытку");
//     return;
// }

// bool result = IsPalindrome(userNum);

// Console.WriteLine(result ? $"Число {userNum} является палиндромом" : $"Число {userNum} не является палиндромом");

/******************************************/
/*** Решение 2 ***/
/******************************************/
void IsPalindrome(int num) 
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num  % 10;
    if (num > 9999 && num < 100000 )
    {
        if (num1 == num5 && num2 == num4)
        {
            Console.WriteLine($"Число {num} является палиндром");
        }
        else Console.WriteLine($"Число {num} не является палиндром");
    }
    else if (num >= 0) Console.WriteLine("Число не является пятизначным");
    else Console.WriteLine("Отрицательное число не может быть палиндромом");
}

Console.WriteLine($"Введите пятизначное число :");
int userNum = Convert.ToInt32(Console.ReadLine()); 
IsPalindrome(userNum);