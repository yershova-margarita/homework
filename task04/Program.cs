// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirddNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (secondNum > max) {
    max = secondNum;
}

if (thirddNum > max) {
    max = thirddNum;
}
 
 Console.WriteLine($"max = {max}");