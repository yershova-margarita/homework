// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите натуральное число");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum > 0)
{
    // Решение через FOR
    // for (int i = 1; i <= userNum; i++)
    // {
    //     if (i % 2 == 0) {
    //         Console.Write($"{i}, ");
    //     }
    // }

    // Решение через WHILE
    int count = 1;
    while (count <= userNum) 
    {
        if (count % 2 == 0) {
            Console.Write($"{count}, ");
        }
        count++;
    }
}
else
{
    Console.Write($"Число {userNum} не является натуральным");
}