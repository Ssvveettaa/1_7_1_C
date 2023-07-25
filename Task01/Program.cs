// Напишите программу, которая:
// 1. На вход принимает два числа;
// 2. Проверяет является ли первое число квадратом второго.
// a = 25, b =  5 –> да
// a =  2, b = 10 –> нет
// a =  9, b = -3 –> да
// a = -3, b =  9 –> нет

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine()); // Квадрат 
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine()); // Множитель

if (number1 == number2 * number2)
{
    Console.WriteLine($"Да, первое число {number1} является квадратом второго {number2}.");
}
else
{
    Console.WriteLine($"Нет, первое число {number1} не является квадратом второго {number2}.");
}