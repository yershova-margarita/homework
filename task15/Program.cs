/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
bool ValidayEnterNum(int num)
{
    if (num > 0 && num < 8)
    {
        return true;
    }
    return false;
}

bool IsWeekend(int number)
{
    if (number == 6 || number == 7)
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Введите число, соответствующее дню недели от 1 до 7");
int userNum = Convert.ToInt32(Console.ReadLine());
if (ValidayEnterNum(userNum)) 
{
    if (IsWeekend(userNum))  Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
}
else Console.WriteLine("Введенное число не соответствует дням недели");