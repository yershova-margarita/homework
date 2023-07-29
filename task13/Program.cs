/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int ThirdDigit(int num)
{
    while (num > 999 || num < -999)
    {
        num = Math.Abs(num / 10);
    }
    return num % 10;
}

Console.WriteLine($"Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum > -100 || userNum < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(ThirdDigit(userNum));