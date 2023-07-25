// Напишите программу, которая будет:
// 1. По заданному номеру;
// 2. Выдавать название дня недели.

Console.WriteLine("Введите номер дня недели (целое число от 1 до 7), чтобы узнать его название:");
int week = Convert.ToInt32(Console.ReadLine());
if (week == 1)
{
    Console.WriteLine("Понедельник");
}
else if (week == 2)
{
    Console.WriteLine("Вторник");
}
else if (week == 3)
{
    Console.WriteLine("Среда");
}
else if (week == 4)
{
    Console.WriteLine("Четверг");
}
else if (week == 5)
{
    Console.WriteLine("Пятница");
}
else if (week == 6)
{
    Console.WriteLine("Суббота");
}
else if (week == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine($"Введённый номер {week} меньше 1, или больше 7.");
}