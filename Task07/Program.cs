// Напишите программу, которая:
// 1. На вход принимает трёхзначное число;
// 2. На выходе показывает последнюю цифру этого числа.
// 456 –> 6
// 782 –> 2
// 918 –> 8

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if (100 <= number && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра числа: {result}");
}
else
{
    Console.WriteLine("Число не трёхзначное");
}