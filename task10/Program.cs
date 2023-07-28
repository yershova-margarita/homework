/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int SecondDigit(int num) { 
    return num /10 % 10;;
}

Console.WriteLine("Введите трехзначное число : ");
int userNum = Convert.ToInt32(Console.ReadLine());
if ((userNum > -100 || userNum < -999) && (userNum < 100 || userNum > 999))
{
    Console.WriteLine($"Число {userNum} не является трехзначным");
}
else 
{
    Console.WriteLine($"Вторая цифра числа {userNum} : {SecondDigit(userNum)}"); ;
}