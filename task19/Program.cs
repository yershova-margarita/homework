/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да
*/

bool IsPalindrome(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        return true;
    }
    return false;
}


Console.WriteLine($"Введите пятизначное число :");
// "?" добавляется , чтобы сделать переменную ссылочным типом, допускаемым значением NULL
string? userNum = Console.ReadLine(); 

// "!" оператор прощения значений NULL
if (userNum!.Length != 5) {
    Console.WriteLine($"Некорректный ввод, повторите попытку");
    return;
}

bool result = IsPalindrome(userNum);

Console.WriteLine(result ? $"Число {userNum} является палиндромом" : $"Число {userNum} не является палиндромом");