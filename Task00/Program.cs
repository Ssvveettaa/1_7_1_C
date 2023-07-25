// Напишите программу, которая:
// 1. На вход принимает число;
// 2. Выдаёт его квадрат (число умноженное само на себя).
// Например:
// 4 –> 16
// -3 –> 9
// -7 –> 49

Console.WriteLine("Введите целое число:");
// int number = int.Parse(Console.ReadLine());    // Преобразование типа string в тип int
int number = Convert.ToInt32(Console.ReadLine()); // Преобразование типа string в тип int
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}."); // Интерполяция
// Console.WriteLine("Квадрат числа " + number + " = " + square + "."); // Конкатенация – склеивание строк